using Newtonsoft.Json;
using Scriban;
using System;
using static Luminous.Core.Object.Property;

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
        public uint nameHash_ { get; set; }
        public string typeName_ { get; set; }
        public string targetTypeName => GetTargetTypeName();
        public uint offset_ { get; set; }
        public uint size_ { get; set; }
        public ushort itemCount_ { get; set; }
        public PrimitiveType primitiveType_ { get; set; }
        public byte attr_ { get; set; }

        private string GetTargetTypeName()
        {
            switch (this.primitiveType_)
            {
                case PrimitiveType.ClassField:
                    return typeName_;
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
                    return typeName_;
                case PrimitiveType.Array:
                    return MakeArrayTargetTypeName();
                case PrimitiveType.PointerArray:
                    return MakePointerArrayTargetTypeName();
                case PrimitiveType.Fixid:
                    // Should this be a string?
                    return "uint";
                case PrimitiveType.Vector4:
                    // TODO
                    return "object";
                case PrimitiveType.Color:
                    // TODO
                    return "object";
                case PrimitiveType.Buffer:
                    return "object";
                case PrimitiveType.Enum:
                    // TODO
                    return "int";
                case PrimitiveType.IntrusivePointerArray:
                    // TODO
                    return "object";
                case PrimitiveType.DoubleVector4:
                    // TODO
                    return "object";
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
            // TODO: Handle nested types like int32_t and Ebony.Base.String :/
            var tokens = typeName_.Split('<', ' ', ',', '>');
            if (typeName_.Contains(","))
            {
                return tokens[tokens.Length - 5];
            }

            return tokens[tokens.Length - 3];
        }

        private string MakePointerArrayTargetTypeName()
        {
            var innerType = ParsePointerArrayTargetTypeName();
            return "IList<" + innerType + ">";
        }

        private string ParsePointerArrayTargetTypeName()
        {
            var tokens = typeName_.Split('<', ' ', ',', '*', '>');
            if (typeName_.Contains(","))
            {
                return tokens[tokens.Length - 6];
            }

            return tokens[tokens.Length - 4];
        }
    }

    public static void GenerateClasses(string schema, string template)
    {
        var objectTypes = JsonConvert.DeserializeObject<SerializedObjectType[]>(schema);
        var parsedTemplate = Template.Parse(template);

        foreach (var objectTypeData in objectTypes)
        {
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

            var result = parsedTemplate.Render(new { nameSpace = typeNamespace, type, baseType = objectTypeData.basetype, objectType = objectTypeData });
            UnityEngine.Debug.Log(result);
        }
    }
}
