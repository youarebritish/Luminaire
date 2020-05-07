using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Mobhunt
{
    public partial class SaveMobhuntDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id_;
		public bool isCleared_;
		public bool isRecieved_;
		public bool isReported_;
		public bool isKilledAll_;
		public bool isNew_;
		public IList<Black.Save.Mobhunt.SaveMobhuntVDataStructNew> mobhuntVDataNewArray_;
		public sbyte killCount0_;
		public sbyte killCount1_;
		public sbyte killCount2_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMobhuntDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Mobhunt.SaveMobhuntDataStruct", 0, Black.Save.Mobhunt.SaveMobhuntDataStruct.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.Save.Mobhunt.SaveMobhuntDataStruct", null, -2065400598, -1936981960);
            
			
			
			fieldProperties.AddProperty(new Property("id_", 2899315373, "SQEX.Ebony.Std.Fixid", 0, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCleared_", 131525108, "bool", 4, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isRecieved_", 2250648127, "bool", 5, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isReported_", 603207647, "bool", 6, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isKilledAll_", 821867844, "bool", 7, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNew_", 3892239546, "bool", 8, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("mobhuntVDataNewArray_", 1103071670, "SQEX.Ebony.Std.DynamicArray< Black.Save.Mobhunt.SaveMobhuntVDataStructNew >", 16, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("killCount0_", 1989168221, "uint8_t", 32, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			fieldProperties.AddProperty(new Property("killCount1_", 3063082932, "uint8_t", 33, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			fieldProperties.AddProperty(new Property("killCount2_", 3063230027, "uint8_t", 34, 1, 1, Property.PrimitiveType.Int8, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}