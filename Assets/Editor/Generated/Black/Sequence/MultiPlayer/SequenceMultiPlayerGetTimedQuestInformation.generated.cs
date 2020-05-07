using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerGetTimedQuestInformation : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inHourly_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inDaily_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inTotal_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outSuccessed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFailed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueQuestId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueTime_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueIsEndReward_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueEndingTime_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueStartingTime_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueScoreType_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueRuleId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueRuleArg_;
		public bool isLocalTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerGetTimedQuestInformation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerGetTimedQuestInformation", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerGetTimedQuestInformation.ObjectType, null, properties, 0, 1392);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerGetTimedQuestInformation", base.GetFieldProperties(), -2142966217, 758995474);
            
			
			
			return fieldProperties;
        }

		
    }
}