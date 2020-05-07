using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Animal
{
    public partial class SequenceActionAnimalRouteMove : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin setActor_;
		public float moveSpeed_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAnimalRouteMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Animal.SequenceActionAnimalRouteMove", 0, Black.Sequence.Actor.AI.Animal.SequenceActionAnimalRouteMove.ObjectType, null, properties, 0, 504);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Animal.SequenceActionAnimalRouteMove", base.GetFieldProperties(), 557071367, 1226857075);
            return fieldProperties;
        }

		
    }
}