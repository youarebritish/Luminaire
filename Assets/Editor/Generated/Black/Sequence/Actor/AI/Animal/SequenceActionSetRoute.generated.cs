using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Animal
{
    public partial class SequenceActionSetRoute : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin setActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inRouteId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin entityIndexPin_;
		public uint routeId_;
		public int activateMode_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetRoute();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Animal.SequenceActionSetRoute", 0, Black.Sequence.Actor.AI.Animal.SequenceActionSetRoute.ObjectType, null, properties, 0, 648);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Animal.SequenceActionSetRoute", base.GetFieldProperties(), -135639737, -45261083);
            
			
			
			return fieldProperties;
        }

		
    }
}