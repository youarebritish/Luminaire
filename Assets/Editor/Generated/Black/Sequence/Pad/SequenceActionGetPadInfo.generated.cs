using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Pad
{
    public partial class SequenceActionGetPadInfo : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin start_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin intStandardRepeated_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin floatStandardSecond_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin intOverrideButtonType_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin repeatStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin repeatEnd_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin repeat_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin stopped_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputOnOff_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputAverageCnt_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin deltaResult_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin released_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fail_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin completed_;
		public bool isFixTime_;
		public bool withMenu_;
		public int padNumber_;
		public int buttonType_;
		public int buttonSameType_;
		public int maxRepeated_;
		public float maxSparseTime_;
		public int borderRepeated_;
		public float limitTime_;
		public int intearporateType_;
		public bool isTimeAverage_;
		public bool isSameTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetPadInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Pad.SequenceActionGetPadInfo", 0, Black.Sequence.Pad.SequenceActionGetPadInfo.ObjectType, null, properties, 0, 2024);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Pad.SequenceActionGetPadInfo", base.GetFieldProperties(), 438848581, -2018698044);
            
			
			
			return fieldProperties;
        }

		
    }
}