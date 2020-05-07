using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI
{
    public partial class SequenceActionAIMoveLineOfFire : Black.Sequence.Actor.AI.SequenceActionAIMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin baseActor;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fireActor;
		public float offsetNear;
		public float distanceToBaseActorMin;
		public float distanceToBaseActorMax;
		public float giveUpFireOfLineLength;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offsetNearPin;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin DistanceMinPin;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin DistanceMaxPin;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin GiveupLengthPin;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIMoveLineOfFire();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.SequenceActionAIMoveLineOfFire", 0, Black.Sequence.Actor.AI.SequenceActionAIMoveLineOfFire.ObjectType, null, properties, 0, 1536);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.SequenceActionAIMoveLineOfFire", base.GetFieldProperties(), -633688306, 793507035);
            
			
			
			return fieldProperties;
        }

		
    }
}