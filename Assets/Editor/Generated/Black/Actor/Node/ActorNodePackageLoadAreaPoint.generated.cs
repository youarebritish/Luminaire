using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Node
{
    public partial class ActorNodePackageLoadAreaPoint : Black.Actor.Node.ActorNodePackageBaseAreaPoint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorNodePackageLoadAreaPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Node.ActorNodePackageLoadAreaPoint", 0, Black.Actor.Node.ActorNodePackageLoadAreaPoint.ObjectType, null, properties, 59, 2048);
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

            fieldProperties = new PropertyContainer("Black.Actor.Node.ActorNodePackageLoadAreaPoint", base.GetFieldProperties(), -2000969373, 277800906);
            return fieldProperties;
        }

		
    }
}