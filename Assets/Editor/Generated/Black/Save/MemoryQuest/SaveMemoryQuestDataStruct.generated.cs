using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.MemoryQuest
{
    public partial class SaveMemoryQuestDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public long worldTime_;
		public string areaFilePath;
		public SQEX.Luminous.Math.DoubleVector4 playerWorldPos;
		public UnityEngine.Vector4 playerRotation;
		public int weatherType_;
		public uint campPoint_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMemoryQuestDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.MemoryQuest.SaveMemoryQuestDataStruct", 0, Black.Save.MemoryQuest.SaveMemoryQuestDataStruct.ObjectType, null, properties, 0, 96);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Save.MemoryQuest.SaveMemoryQuestDataStruct", null, 1223645893, 1185758535);
            
			
			
			fieldProperties.AddProperty(new Property("worldTime_", 2726902703, "int64_t", 0, 8, 1, Property.PrimitiveType.Int64, 0, (char)0));
			fieldProperties.AddProperty(new Property("areaFilePath", 1531240753, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("playerWorldPos", 3643738574, "Luminous.Math.DoubleVector4", 24, 32, 1, Property.PrimitiveType.DoubleVector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("playerRotation", 2221299110, "Luminous.Math.VectorA", 64, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("weatherType_", 601680828, "int", 80, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("campPoint_", 1005869999, "SQEX.Ebony.Std.Fixid", 84, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}