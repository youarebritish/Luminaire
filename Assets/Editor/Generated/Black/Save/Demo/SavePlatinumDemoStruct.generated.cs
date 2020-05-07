using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Demo
{
    public partial class SavePlatinumDemoStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public sbyte carbuncleName_;
		public bool isClear_;
		public long total_seconds;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SavePlatinumDemoStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Demo.SavePlatinumDemoStruct", 0, Black.Save.Demo.SavePlatinumDemoStruct.ObjectType, null, properties, 0, 272);
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

            fieldProperties = new PropertyContainer("Black.Save.Demo.SavePlatinumDemoStruct", null, -1620242067, -1914306695);
            
			
			
			return fieldProperties;
        }

		
    }
}