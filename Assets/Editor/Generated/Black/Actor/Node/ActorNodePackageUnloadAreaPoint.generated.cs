using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Node
{
    public partial class ActorNodePackageUnloadAreaPoint : Black.Actor.Node.ActorNodePackageBaseAreaPoint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorNodePackageUnloadAreaPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Node.ActorNodePackageUnloadAreaPoint", 0, Black.Actor.Node.ActorNodePackageUnloadAreaPoint.ObjectType, null, properties, 59, 1360);
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

            fieldProperties = new PropertyContainer("Black.Actor.Node.ActorNodePackageUnloadAreaPoint", base.GetFieldProperties(), 922270123, -778496072);
            
			
			
			return fieldProperties;
        }

		
    }
}