using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.StrongPoint
{
    public partial class StrongPoint : Black.Actor.Node.ActorNodePoint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new StrongPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.StrongPoint.StrongPoint", 0, Black.AI.StrongPoint.StrongPoint.ObjectType, null, properties, 0, 1040);
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

            fieldProperties = new PropertyContainer("Black.AI.StrongPoint.StrongPoint", base.GetFieldProperties(), -511051136, 1795171111);
            
			
			
			return fieldProperties;
        }

		
    }
}