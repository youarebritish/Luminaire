using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Node
{
    public partial class ActorNodeFoliageDummy : Black.Actor.Node.ActorNodePoint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorNodeFoliageDummy();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Node.ActorNodeFoliageDummy", 0, Black.Actor.Node.ActorNodeFoliageDummy.ObjectType, null, properties, 59, 960);
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

            fieldProperties = new PropertyContainer("Black.Actor.Node.ActorNodeFoliageDummy", base.GetFieldProperties(), -46465890, -2042515221);
            return fieldProperties;
        }

		
    }
}