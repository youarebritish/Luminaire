using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Node
{
    public partial class ActorNodePackageBaseAreaPoint : Black.Actor.Node.ActorNodeTrigger
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorNodePackageBaseAreaPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Node.ActorNodePackageBaseAreaPoint", 0, Black.Actor.Node.ActorNodePackageBaseAreaPoint.ObjectType, null, properties, 59, 1360);
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

            fieldProperties = new PropertyContainer("Black.Actor.Node.ActorNodePackageBaseAreaPoint", base.GetFieldProperties(), 68865991, 571771199);
            
			
			
			return fieldProperties;
        }

		
    }
}