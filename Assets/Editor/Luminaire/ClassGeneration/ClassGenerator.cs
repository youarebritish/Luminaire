using Newtonsoft.Json;
using Scriban;
using System;
using System.IO;
using static SQEX.Luminous.Core.Object.Property;

public static class ClassGenerator
{
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
    }

    private class SerializedProperty
    {
        public string name_ { get; set; }
        public string ValidName => GetNameValid();
        public uint nameHash_ { get; set; }
        public string typeName_ { get; set; }
        public string targetTypeName => GetTargetTypeName();
        public uint offset_ { get; set; }
        public uint size_ { get; set; }
        public ushort itemCount_ { get; set; }
        public PrimitiveType primitiveType_ { get; set; }
        public string PrimitiveTypeName => primitiveType_.ToString();
        public byte attr_ { get; set; }

        private string GetTargetTypeName()
        {
            switch (primitiveType_)
            {
                case PrimitiveType.ClassField:
                    return GetValidType(typeName_);
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
                    return GetValidType(typeName_);
                case PrimitiveType.Array:
                    return MakeArrayTargetTypeName();
                case PrimitiveType.PointerArray:
                    return MakePointerArrayTargetTypeName();
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
                    return MakeArrayTargetTypeName();
                case PrimitiveType.DoubleVector4:
                    return "SQEX.Luminous.Math.DoubleVector4";
                default:
                    throw new NotImplementedException();
            }
        }
        private string MakeArrayTargetTypeName()
        {
            var innerType = ParseArrayTargetTypeName();
            return "IList<" + innerType + ">";
        }

        private string ParseArrayTargetTypeName()
        {
            var tokens = typeName_.Split('<', ' ', ',', '>');
            var innerType = tokens[tokens.Length - 3];
            if (typeName_.Contains(","))
            {
                innerType = tokens[tokens.Length - 5];
            }

            return GetValidType(innerType);
        }

        private string MakePointerArrayTargetTypeName()
        {
            var innerType = ParsePointerArrayTargetTypeName();
            return "IList<" + innerType + ">";
        }

        private string ParsePointerArrayTargetTypeName()
        {
            var tokens = typeName_.Split('<', ' ', ',', '*', '>');
            var innerType = tokens[tokens.Length - 4];
            if (typeName_.Contains(","))
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
            if (name_ == "in")
            {
                return "@in";
            }
            else if (name_ == "out")
            {
                return "@out";
            }
            else
            {
                return name_;
            }
        }
    }

    public static void GenerateClasses(string schema, string template)
    {
        var objectTypes = JsonConvert.DeserializeObject<SerializedObjectType[]>(schema);
        var parsedTemplate = Template.Parse(template);

        var depth = 100;

        foreach (var objectTypeData in objectTypes)
        {
            depth--;
            if (depth <= 0)
            {
                return;
            }

            if (objectTypeData.name_.Contains("SaveAvatarModDataStruct"))
            {
                // Don't bother, causes some annoying compile errors and I don't think we can use it for anything useful anyway
                continue;
            }

            if (objectTypeData.name_.Contains("IconDataStruct"))
            {
                // These two are annoying edge cases of inner classes and it's too annoying to handle them with the template, so I've implemented them manually.
                continue;
            }

            if (objectTypeData.name_.Contains("ChocoboDataStruct"))
            {
                continue;
            }

            var typeTokens = objectTypeData.name_.Split('.');
            if (typeTokens.Length < 2)
            {
                continue;
            }

            var type = typeTokens[typeTokens.Length - 1];
            var typeNamespace = string.Empty;
            for(var i = 0; i < typeTokens.Length - 1; i++)
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

            var result = parsedTemplate.Render(new { nameSpace = typeNamespace, type, baseType = objectTypeData.basetype, objectType = objectTypeData });
            var filePath = MakeOutputPath(typeNamespace + "." + type);

            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllText(filePath, result);
        }
    }

    private const string OutputDirectory = "/Editor/Generated/";

    private static string MakeOutputPath(string typeName)
    {
        var filePath = typeName.Replace(".", "/");
        return UnityEngine.Application.dataPath + OutputDirectory + filePath + ".generated.cs";
    }
}
