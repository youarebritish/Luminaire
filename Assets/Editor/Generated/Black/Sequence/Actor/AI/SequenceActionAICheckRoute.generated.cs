using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI
{
    public partial class SequenceActionAICheckRoute : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin @in;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin findRoute;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin findRouteWithJump;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin notFound;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin goal;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAICheckRoute();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.SequenceActionAICheckRoute", 0, Black.Sequence.Actor.AI.SequenceActionAICheckRoute.ObjectType, null, properties, 0, 656);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.SequenceActionAICheckRoute", base.GetFieldProperties(), -352555868, -1067564765);
            
			
			
			return fieldProperties;
        }

		
    }
}