using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor
{
    public partial class ActorDiffuseLightProbe : Black.Actor.ActorAnimatedModel
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorDiffuseLightProbe();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.ActorDiffuseLightProbe", 0, Black.Actor.ActorDiffuseLightProbe.ObjectType, null, properties, 59, 5952);
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

            fieldProperties = new PropertyContainer("Black.Actor.ActorDiffuseLightProbe", base.GetFieldProperties(), -167287041, 1486271940);
            return fieldProperties;
        }

		
    }
}