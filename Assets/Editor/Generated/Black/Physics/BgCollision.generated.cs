using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Physics
{
    public partial class BgCollision
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BgCollision();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Physics.BgCollision", 0, Black.Physics.BgCollision.ObjectType, null, properties, 0, 4);
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

            fieldProperties = new PropertyContainer("Black.Physics.BgCollision", null, 150801921, 553557005);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}