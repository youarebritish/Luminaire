using Newtonsoft.Json;
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
        public uint offset_ { get; set; }
        public uint size_ { get; set; }
        public ushort itemCount_ { get; set; }
        public PrimitiveType primitiveType_ { get; set; }
        public byte attr_ { get; set; }
    }

    public static void GenerateClasses(string schema, string template)
    {
        var objectTypes = JsonConvert.DeserializeObject<SerializedObjectType[]>(schema);
        var five = 5;
    }
}
