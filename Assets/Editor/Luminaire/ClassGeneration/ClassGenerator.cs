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
        "Black.Save.Multiplay.SaveChocoboDataStruct.ChocoboDataStruct"
        };

    private class SerializedObjectType
    {
        public string name_ { get; set; }
        public uint thistype { get; set; }
        public string basetype { get; set; }
        public ulong constructFunction_ { get; set; }
        public ulong constructFunction2_ { get; set; }
        public ulong singletonFunction_ { get; set; }
        public SerializedPropertyContainer propertyContainer_ { get; set; }
        public uint functionCount_ { get; set; }
        public int objectSize_ { get; set; }
    }

    private class SerializedPropertyContainer
    {
        public int nameHashCode_ { get; set; }
        public int versionHashCode_ { get; set; }
        public ushort allPropertiesClassFieldCount_ { get; set; }
        public SerializedProperty[] myProperties_ { get; set; }
        public SerializedProperty[] allProperties_ { get; set; }

        public IEnumerable<SerializedProperty> InheritedProperties => from property in this.allProperties_
                                                                      where !this.myProperties_.Any(myProperty => myProperty.name_ == property.name_)
                                                                      select property;
    }

    private class SerializedProperty
    {
        public string name_ { get; set; }
        public string ValidName => this.GetNameValid();
        public uint nameHash_ { get; set; }
        public string typeName_ { get; set; }
        public string targetTypeName => this.GetTargetTypeName();
        public uint offset_ { get; set; }
        public uint size_ { get; set; }
        public ushort itemCount_ { get; set; }
        public PrimitiveType primitiveType_ { get; set; }
        public string PrimitiveTypeName => this.primitiveType_.ToString();

        public string Initialization
        {
            get
            {
                if (this.targetTypeName == "string")
                {
                    return "= string.Empty";
                }
                else if (this.targetTypeName.StartsWith("IList<"))
                {
                    return "= new " + this.targetTypeName.Substring(1) + "()";
                }

                return string.Empty;
            }
        }

        public byte attr_ { get; set; }

        private string GetTargetTypeName()
        {
            switch (this.primitiveType_)
            {
                case PrimitiveType.ClassField:
                    return GetValidType(this.typeName_);

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
                    return GetValidType(this.typeName_);

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
            var tokens = this.typeName_.Split('<', ' ', ',', '>');
            var innerType = tokens[tokens.Length - 3];
            if (this.typeName_.Contains(","))
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
            var tokens = this.typeName_.Split('<', ' ', ',', '*', '>');
            var innerType = tokens[tokens.Length - 4];
            if (this.typeName_.Contains(","))
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
            if (this.name_ == "in")
            {
                return "@in";
            }
            else if (this.name_ == "out")
            {
                return "@out";
            }
            else
            {
                return this.name_;
            }
        }
    }

    public static void GenerateClasses(string schema, string classTemplate, string setupTemplate)
    {
        var objectTypes = from type in JsonConvert.DeserializeObject<SerializedObjectType[]>(schema)
                          where !TypesToSkip.Contains(type.name_)
                          select type;

        var parsedClassTemplate = Template.Parse(classTemplate);

        if (false)
        {
            foreach (var objectTypeData in objectTypes)
            {
                var typeTokens = objectTypeData.name_.Split('.');
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

                if (string.IsNullOrEmpty(objectTypeData.basetype))
                {
                    objectTypeData.basetype = null;
                }

                var result = parsedClassTemplate.Render(new { nameSpace = typeNamespace, type, baseType = objectTypeData.basetype, objectType = objectTypeData });
                var filePath = MakeOutputPath(typeNamespace + "." + type);

                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, result);
            }
        }

        // Generate EntityModuleSetup class
        var parsedSetupTemplate = Template.Parse(setupTemplate);

        var types = (from objectType in objectTypes
                    select objectType.name_).ToArray();

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