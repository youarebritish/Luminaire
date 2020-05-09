namespace Luminaire.ClassGeneration
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;
    using Scriban;
    using Scriban.Runtime;
    using static SQEX.Luminous.Core.Object.Property;

    public static class ClassGenerator
    {
        private const string OutputDirectory = "/Editor/Generated/";
        private static readonly IReadOnlyCollection<string> TypesToSkip = new SortedSet<string>
        {
        "BaseObject",
        "EffectiveCamera",
        "ObjectiveCameraBase",
        "ObjectiveCameraSimple",
        "ObjectiveCameraVehicle",
        "TargetCameraBase",
        "ObjectiveCameraHumanBase",
        "ObjectiveCamera",
        "Black.Save.Multiplay.SaveAvatarModDataStruct",
        "Black.Save.Multiplay.SaveAvatarModDataStruct.MODITEM_STYLEEDITENTRY_PATHSET",
        "EventCamera2",
        "SaveChocoboDataStruct",
        "Black.Save.Multiplay.SaveAvatarModDataStruct",
        "Black.Save.Multiplay.SaveAvatarModDataStruct.MODITEM_STYLEEDITENTRY_PATHSET",
        "Black.Save.Multiplay.SaveChocoboDataStruct",
        "Black.Save.Multiplay.SaveChocoboDataStruct.ChocoboDataStruct",
        "Black.Save.Multiplay.SavePlantMapDataStruct",
        "Black.Save.Multiplay.SavePlantMapDataStruct.IconDataStruct"
        };

        private class SerializedObjectType
        {
            [JsonProperty("name_")]
            public string Name { get; set; }
            [JsonProperty("thistype")]
            public uint ThisType { get; set; }
            [JsonProperty("basetype")]
            public string BaseType { get; set; }
            [JsonProperty("constructFunction_")]
            public ulong ConstructFunction { get; set; }
            [JsonProperty("constructFunction2_")]
            public ulong ConstructFunction2 { get; set; }
            public bool HasConstructor => this.ConstructFunction2 != 0;
            [JsonProperty("singletonFunction_")]
            public ulong SingletonFunction { get; set; }
            [JsonProperty("propertyContainer_")]
            public SerializedPropertyContainer PropertyContainer { get; set; }
            [JsonProperty("functionCount_")]
            public uint FunctionCount { get; set; }
            [JsonProperty("objectSize_")]
            public int ObjectSize { get; set; }
        }

        private class SerializedPropertyContainer
        {
            [JsonProperty("nameHashCode_")]
            public int NameHashCode { get; set; }
            [JsonProperty("versionHashCode_")]
            public int VersionHashCode { get; set; }
            [JsonProperty("allPropertiesClassFieldCount_")]
            public ushort AllPropertiesClassFieldCount { get; set; }
            [JsonProperty("myProperties_")]
            public SerializedProperty[] MyProperties { get; set; }
            [JsonProperty("allProperties_")]
            public SerializedProperty[] AllProperties { get; set; }

            public IEnumerable<SerializedProperty> InheritedProperties => from property in this.AllProperties
                                                                          where !this.MyProperties.Any(myProperty => myProperty.Name == property.Name)
                                                                          select property;
        }

        private class SerializedProperty
        {
            [JsonProperty("name_")]
            public string Name { get; set; }
            public string ValidName => this.GetNameValid();
            [JsonProperty("nameHash_")]
            public uint NameHash { get; set; }
            [JsonProperty("typeName_")]
            public string TypeName { get; set; }
            public string TargetTypeName => this.GetTargetTypeName();
            [JsonProperty("offset_")]
            public uint Offset { get; set; }
            [JsonProperty("size_")]
            public uint Size { get; set; }
            [JsonProperty("itemCount_")]
            public ushort ItemCount { get; set; }
            [JsonProperty("primitiveType_")]
            public PrimitiveType PrimitiveType { get; set; }
            public string PrimitiveTypeName => this.PrimitiveType.ToString();

            [JsonProperty("attr_")]
            public byte attr { get; set; }

            public string Initialization
            {
                get
                {
                    if (this.TargetTypeName == "string")
                    {
                        return "= string.Empty";
                    }
                    else if (this.TargetTypeName.StartsWith("IList<"))
                    {
                        return "= new " + this.TargetTypeName.Substring(1) + "()";
                    }

                    return string.Empty;
                }
            }

            private string GetTargetTypeName()
            {
                switch (this.PrimitiveType)
                {
                    case PrimitiveType.ClassField:
                        return GetValidType(this.TypeName);

                    case PrimitiveType.Int8:
                        return "sbyte";

                    case PrimitiveType.Int16:
                        return "short";

                    case PrimitiveType.Int32:
                        return "int";

                    case PrimitiveType.Int64:
                        return "long";

                    case PrimitiveType.UInt8:
                        return "byte";

                    case PrimitiveType.UInt16:
                        return "ushort";

                    case PrimitiveType.UInt32:
                        return "uint";

                    case PrimitiveType.UInt64:
                        return "ulong";

                    case PrimitiveType.Bool:
                        return "bool";

                    case PrimitiveType.Float:
                        return "float";

                    case PrimitiveType.Double:
                        return "double";

                    case PrimitiveType.String:
                        return "string";

                    case PrimitiveType.Pointer:
                        return GetValidType(this.TypeName);

                    case PrimitiveType.Array:
                        return this.MakeArrayTargetTypeName();

                    case PrimitiveType.PointerArray:
                        return this.MakePointerArrayTargetTypeName();

                    case PrimitiveType.Fixid:
                        return "uint";

                    case PrimitiveType.Vector4:
                        return "UnityEngine.Vector4";

                    case PrimitiveType.Color:
                        return "UnityEngine.Color";

                    case PrimitiveType.Buffer:
                        return "object";

                    case PrimitiveType.Enum:
                        // TODO
                        return "int";

                    case PrimitiveType.IntrusivePointerArray:
                        return this.MakeArrayTargetTypeName();

                    case PrimitiveType.DoubleVector4:
                        return "SQEX.Luminous.Math.DoubleVector4";

                    default:
                        throw new NotImplementedException();
                }
            }

            private string MakeArrayTargetTypeName()
            {
                var innerType = this.ParseArrayTargetTypeName();
                return "IList<" + innerType + ">";
            }

            private string ParseArrayTargetTypeName()
            {
                var tokens = this.TypeName.Split('<', ' ', ',', '>');
                var innerType = tokens[tokens.Length - 3];
                if (this.TypeName.Contains(","))
                {
                    innerType = tokens[tokens.Length - 5];
                }

                return GetValidType(innerType);
            }

            private string MakePointerArrayTargetTypeName()
            {
                var innerType = this.ParsePointerArrayTargetTypeName();
                return "IList<" + innerType + ">";
            }

            private string ParsePointerArrayTargetTypeName()
            {
                var tokens = this.TypeName.Split('<', ' ', ',', '*', '>');
                var innerType = tokens[tokens.Length - 4];
                if (this.TypeName.Contains(","))
                {
                    innerType = tokens[tokens.Length - 6];
                }

                return GetValidType(innerType);
            }

            private static string GetValidType(string type)
            {
                if (type == "void")
                {
                    return "object";
                }
                else if (type == "Luminous.Std.EventHandler< float >")
                {
                    return "object";
                }
                else if (type.EndsWith(".String"))
                {
                    return "string";
                }
                else if (type == "SQEX.Ebony.Std.Fixid")
                {
                    return "uint";
                }
                else if (type == "uint32_t")
                {
                    return "uint";
                }
                else if (type == "Luminous.Math.QuatA")
                {
                    return "UnityEngine.Vector4";
                }
                else if (type == "Luminous.Math.VectorA")
                {
                    return "UnityEngine.Vector4";
                }
                else if (type == "Luminous.RenderInterface.Color")
                {
                    return "UnityEngine.Color";
                }
                else if (type == "Base.Object.Object")
                {
                    return "Luminous.Core.Object.Object";
                }
                else if (type == "Black.Save.Menu.SaveMenuFootprint.BitsetType")
                {
                    return "uint";
                }
                else if (type == "QuestSaveInformation.ConditionWork")
                {
                    return "Black.Quest.Information.QuestSaveInformation.ConditionWork";
                }

                return type;
            }

            public string GetNameValid()
            {
                if (this.Name == "in")
                {
                    return "@in";
                }
                else if (this.Name == "out")
                {
                    return "@out";
                }
                else
                {
                    return this.Name;
                }
            }
        }

        public static void GenerateClasses(string schema, string classTemplate, string setupTemplate)
        {
            var objectTypes = from type in JsonConvert.DeserializeObject<SerializedObjectType[]>(schema)
                              where !TypesToSkip.Contains(type.Name)
                              select type;

            var parsedClassTemplate = Template.Parse(classTemplate);

            if (true)
            {
                foreach (var objectTypeData in objectTypes)
                {
                    var typeTokens = objectTypeData.Name.Split('.');
                    if (typeTokens.Length < 2)
                    {
                        continue;
                    }

                    var type = typeTokens[typeTokens.Length - 1];
                    var typeNamespace = string.Empty;
                    for (var i = 0; i < typeTokens.Length - 1; i++)
                    {
                        typeNamespace += typeTokens[i];

                        if (i != typeTokens.Length - 2)
                        {
                            typeNamespace += ".";
                        }
                    }

                    if (string.IsNullOrEmpty(objectTypeData.BaseType))
                    {
                        objectTypeData.BaseType = null;
                    }

                    var result = parsedClassTemplate.Render(new { nameSpace = typeNamespace, type, baseType = objectTypeData.BaseType, objectType = objectTypeData });
                    var filePath = MakeOutputPath(typeNamespace + "." + type);

                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                    File.WriteAllText(filePath, result);
                }
            }

            // Generate EntityModuleSetup class
            var parsedSetupTemplate = Template.Parse(setupTemplate);

            var types = (from objectType in objectTypes
                         select objectType.Name).ToArray();

            var scriptObject = new ScriptObject();
            scriptObject.Import(new { types });

            var context = new TemplateContext { LoopLimit = 4000 };
            context.PushGlobal(scriptObject);

            var setupCode = parsedSetupTemplate.Render(context);

            var setupPath = MakeOutputPath("Black.Entity.EntityModuleSetup");
            Directory.CreateDirectory(Path.GetDirectoryName(setupPath));
            File.WriteAllText(setupPath, setupCode);
        }

        private static string MakeOutputPath(string typeName)
        {
            var filePath = typeName.Replace(".", "/");
            return UnityEngine.Application.dataPath + OutputDirectory + filePath + ".generated.cs";
        }
    }
}