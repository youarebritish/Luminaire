using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable.Labeled
{
    public partial class SequenceVariableLabeledCommonBase : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int labelScope_;
		public bool isCreateWhenNotFound_;
		public bool useTimer_;
		public Black.System.Labeled.LabeledVariableManager.TimerType timerType_;
		public float stopTimerValue_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableLabeledCommonBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.Labeled.SequenceVariableLabeledCommonBase", 0, Black.Sequence.Variable.Labeled.SequenceVariableLabeledCommonBase.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.Labeled.SequenceVariableLabeledCommonBase", base.GetFieldProperties(), -1130013867, 166230714);
            
			
			
			return fieldProperties;
        }

		
    }
}