using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Action
{
    public partial class SequenceActionTimeLine : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reverseInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pauseInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin endInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin preparedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin skippedOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin playRateInputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin playSpecificFrameInputPin_;
		public int timeLineType_;
		public bool isLooping_;
		public bool rewindOnPlay_;
		public float playRate_;
		public bool isReflectTimeRate_;
		public uint eventId_;
		public bool isOverrideEnvironment4Event_;
		public bool isEnableSkip_;
		public bool isEnableEventSkip_;
		public int eventSkipFrame_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLine();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLine", 0, SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLine.ObjectType, null, properties, 0, 1504);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLine", base.GetFieldProperties(), -471883699, -545527877);
            return fieldProperties;
        }

		
    }
}