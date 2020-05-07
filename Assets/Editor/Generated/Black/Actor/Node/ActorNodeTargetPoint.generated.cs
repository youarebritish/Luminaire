using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Node
{
    public partial class ActorNodeTargetPoint : Black.Actor.Node.ActorNodePoint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorNodeTargetPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Node.ActorNodeTargetPoint", 0, Black.Actor.Node.ActorNodeTargetPoint.ObjectType, null, properties, 59, 1072);
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

            fieldProperties = new PropertyContainer("Black.Actor.Node.ActorNodeTargetPoint", base.GetFieldProperties(), -1631250630, -489645968);
            return fieldProperties;
        }

		
    }
}