using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI
{
    public partial class SequenceActionAIApproachMove : Black.Sequence.Actor.AI.SequenceActionAIMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValue_;
		public float offsetNear_;
		public float offsetFar_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offsetNearPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offsetFarPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moveTargetOffset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIApproachMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.SequenceActionAIApproachMove", 0, Black.Sequence.Actor.AI.SequenceActionAIApproachMove.ObjectType, null, properties, 0, 1280);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.SequenceActionAIApproachMove", base.GetFieldProperties(), -596080586, -1272796585);
            
			
			
			return fieldProperties;
        }

		
    }
}