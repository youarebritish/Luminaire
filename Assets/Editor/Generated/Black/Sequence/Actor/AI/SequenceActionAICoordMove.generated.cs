using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI
{
    public partial class SequenceActionAICoordMove : Black.Sequence.Actor.AI.SequenceActionAIMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValue_;
		public float offsetNear_;
		public float offsetFar_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offsetNearPin;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offsetFarPin;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAICoordMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.SequenceActionAICoordMove", 0, Black.Sequence.Actor.AI.SequenceActionAICoordMove.ObjectType, null, properties, 0, 1168);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.SequenceActionAICoordMove", base.GetFieldProperties(), 1909646918, -176723299);
            return fieldProperties;
        }

		
    }
}