using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionExecAIModeWait : Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_;
		public int targetType_;
		public float timeout_;
		public float enableDistance_;
		public float disableDistance_;
		public bool bOnceTurn_;
		public bool bTurnOnly_;
		public bool bKeepTargetAngle_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecAIModeWait();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeWait", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeWait.ObjectType, null, properties, 0, 1416);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeWait", base.GetFieldProperties(), -771234035, 439837423);
            return fieldProperties;
        }

		
    }
}