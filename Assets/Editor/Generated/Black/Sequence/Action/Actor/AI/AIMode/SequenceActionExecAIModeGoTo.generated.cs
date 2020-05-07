using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionExecAIModeGoTo : Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin speedRatePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_;
		public int movement_;
		public float speedRate_;
		public float timeout_;
		public bool bCorrectionOfcoordinates_;
		public float arrivalDistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecAIModeGoTo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeGoTo", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeGoTo.ObjectType, null, properties, 0, 1472);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeGoTo", base.GetFieldProperties(), -1204277086, -243042483);
            return fieldProperties;
        }

		
    }
}