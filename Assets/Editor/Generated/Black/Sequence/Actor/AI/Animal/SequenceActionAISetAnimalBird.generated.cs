using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Animal
{
    public partial class SequenceActionAISetAnimalBird : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin setActor_;
		public int animStart_;
		public float cruisingForwardRatioMin_;
		public float moveSpeedMin_;
		public float cruisingForwardRatioMax_;
		public float moveSpeedMax_;
		public float moveAcceleration_;
		public float yawRotationSpeedMax_;
		public float yawAcceleration_;
		public float pitchRotationSpeedMax_;
		public float pitchAcceleration_;
		public float pitchLimitedAngle_;
		public float normalAltitude_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAISetAnimalBird();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Animal.SequenceActionAISetAnimalBird", 0, Black.Sequence.Actor.AI.Animal.SequenceActionAISetAnimalBird.ObjectType, null, properties, 0, 512);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Animal.SequenceActionAISetAnimalBird", base.GetFieldProperties(), 22580362, -1960246406);
            return fieldProperties;
        }

		
    }
}