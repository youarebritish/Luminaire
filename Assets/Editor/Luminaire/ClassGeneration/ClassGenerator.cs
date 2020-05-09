namespace Luminaire.ClassGeneration
{
    using Newtonsoft.Json;
    using Scriban;
    using Scriban.Runtime;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using UnityEngine.Assertions;
    using static SQEX.Luminous.Core.Object.Property;

    /// <summary>
    /// Generates C# class files for Luminous engine type data.
    /// </summary>
    public static class ClassGenerator
    {
        /// <summary>
        /// Output directory for the generated files.
        /// </summary>
        private const string OutputDirectory = "/Editor/Generated/";

        /// <summary>
        /// Suffix for the generated files.
        /// </summary>
        private const string GeneratedFileSuffix = ".generated.cs";

        /// <summary>
        /// Name for the object setup class.
        /// </summary>
        private const string SetupClassTypeName = "Black.Entity.EntityModuleSetup";

        /// <summary>
        /// Names of types to not generated, perhaps because they're problematic, manually implemented, or merely annoying.
        /// </summary>
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

        /// <summary>
        /// Serialized type metadata.
        /// </summary>
        private class SerializedObjectType
        {
            [JsonProperty("name_")]
            public string Name { get; set; }

            [JsonProperty("thistype")]
            public uint ThisType { get; set; }

            [JsonProperty("basetype")]
            public string BaseType { get; set; }

            public bool HasBaseType => !string.IsNullOrEmpty(this.BaseType);

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

        /// <summary>
        /// Serialized property container metadata.
        /// </summary>
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

        /// <summary>
        /// Serialized property metadata.
        /// </summary>
        private class SerializedProperty
        {
            [JsonProperty("name_")]
            public string Name { get; set; }

            public string ValidName => this.NameValid;

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
            public byte Attr { get; set; }

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

            private string GetTargetTypeName() => this.PrimitiveType switch
            {
                PrimitiveType.ClassField => GetValidType(this.TypeName),
                PrimitiveType.Int8 => "sbyte",
                PrimitiveType.Int16 => "short",
                PrimitiveType.Int32 => "int",
                PrimitiveType.Int64 => "long",
                PrimitiveType.UInt8 => "byte",
                PrimitiveType.UInt16 => "ushort",
                PrimitiveType.UInt32 => "uint",
                PrimitiveType.UInt64 => "ulong",
                PrimitiveType.Bool => "bool",
                PrimitiveType.Float => "float",
                PrimitiveType.Double => "double",
                PrimitiveType.String => "string",
                PrimitiveType.Pointer => GetValidType(this.TypeName),
                PrimitiveType.Array => this.MakeArrayTargetTypeName(),
                PrimitiveType.PointerArray => this.MakePointerArrayTargetTypeName(),
                PrimitiveType.Fixid => "uint",
                PrimitiveType.Vector4 => "UnityEngine.Vector4",
                PrimitiveType.Color => "UnityEngine.Color",
                PrimitiveType.Buffer => "object",
                PrimitiveType.Enum => "int",// TODO
                PrimitiveType.IntrusivePointerArray => this.MakeArrayTargetTypeName(),
                PrimitiveType.DoubleVector4 => "SQEX.Luminous.Math.DoubleVector4",
                _ => throw new NotImplementedException(),
            };

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

            public string NameValid
            {
                get
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
        }

        /// <summary>
        /// Generate C# class files for the provided object type data.
        /// </summary>
        /// <param name="schema">The object type data in JSON format.</param>
        /// <param name="classTemplate">Template for the class files.</param>
        /// <param name="setupTemplate">Template for the class setup file.</param>
        public static void GenerateClasses(string schema, string classTemplate, string setupTemplate)
        {
            Assert.IsNotNull(schema);
            Assert.IsNotNull(classTemplate);
            Assert.IsNotNull(setupTemplate);

            var objectTypes = ParseObjectTypes(schema);
            var parsedClassTemplate = Template.Parse(classTemplate);

            GenerateClasses(objectTypes, parsedClassTemplate);

            var typeNames = from objectType in objectTypes
                            select objectType.Name;

            GenerateSetupClass(setupTemplate, typeNames);
        }

        private static void GenerateSetupClass(string setupTemplate, IEnumerable<string> types)
        {
            var setupCode = GenerateSetupClassCode(setupTemplate, types);
            WriteOutput(setupCode, SetupClassTypeName);
        }

        private static void WriteOutput(string code, string typeName)
        {
            var path = MakeOutputPath(typeName);
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            File.WriteAllText(path, code);
        }

        private static string GenerateSetupClassCode(string setupTemplate, IEnumerable<string> types)
        {
            var parsedSetupTemplate = Template.Parse(setupTemplate);
            var context = CreateSetupTemplateContext(types);
            return parsedSetupTemplate.Render(context);
        }

        private static TemplateContext CreateSetupTemplateContext(IEnumerable<string> types)
        {
            var scriptObject = new ScriptObject();
            scriptObject.Import(new { types });

            var context = new TemplateContext { LoopLimit = 4000 };
            context.PushGlobal(scriptObject);

            return context;
        }

        private static void GenerateClasses(IEnumerable<SerializedObjectType> objectTypes, Template parsedClassTemplate)
        {
            foreach (var (objectTypeData, typeTokens) in from objectTypeData in objectTypes
                                                         let typeTokens = objectTypeData.Name.Split('.')
                                                         select (objectTypeData, typeTokens))
            {
                var typeNamespace = ExtractNamespace(typeTokens);
                var type = typeTokens[typeTokens.Length - 1];

                var result = parsedClassTemplate.Render(new { nameSpace = typeNamespace, type, baseType = objectTypeData.BaseType, objectType = objectTypeData });
                WriteOutput(result, typeNamespace + "." + type);
            }
        }

        private static string ExtractNamespace(string[] typeTokens)
        {
            var typeNamespace = string.Empty;
            for (var i = 0; i < typeTokens.Length - 1; i++)
            {
                typeNamespace += typeTokens[i];

                if (i != typeTokens.Length - 2)
                {
                    typeNamespace += ".";
                }
            }

            return typeNamespace;
        }

        /// <summary>
        /// Parse the object type data.
        /// </summary>
        /// <param name="schema">The JSON object type data.</param>
        /// <returns>The parsed object type data.</returns>
        private static IEnumerable<SerializedObjectType> ParseObjectTypes(string schema)
        {
            return from type in JsonConvert.DeserializeObject<SerializedObjectType[]>(schema)
                   where !TypesToSkip.Contains(type.Name)
                   select type;
        }

        /// <summary>
        /// Make the output filename for a generated C# class file.
        /// </summary>
        /// <param name="typeName">The fully qualified name of the C# type.</param>
        /// <returns>Absolute path to the file to write to.</returns>
        private static string MakeOutputPath(string typeName)
        {
            Assert.IsNotNull(typeName);

            var filePath = typeName.Replace(".", "/");
            return $"{UnityEngine.Application.dataPath}{OutputDirectory}{filePath}{GeneratedFileSuffix}";
        }
    }
}