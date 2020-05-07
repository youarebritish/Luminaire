using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Node
{
    public partial class ActorNodeDisplacementArea : Black.Actor.Node.ActorNodeTriggerBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorNodeDisplacementArea();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Node.ActorNodeDisplacementArea", 0, Black.Actor.Node.ActorNodeDisplacementArea.ObjectType, null, properties, 59, 1200);
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

            fieldProperties = new PropertyContainer("Black.Actor.Node.ActorNodeDisplacementArea", base.GetFieldProperties(), 1899830321, -1342884195);
            return fieldProperties;
        }

		
    }
}