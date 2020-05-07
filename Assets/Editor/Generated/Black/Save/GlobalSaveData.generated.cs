using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save
{
    public partial class GlobalSaveData : SQEX.Luminous.Core.Object.Object
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool OpenGarally;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new GlobalSaveData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.GlobalSaveData", 0, Black.Save.GlobalSaveData.ObjectType, null, properties, 0, 24);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Save.GlobalSaveData", base.GetFieldProperties(), 1394919505, 1056218891);
            
			
			
			fieldProperties.AddProperty(new Property("OpenGarally", 3456621659, "bool", 16, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}