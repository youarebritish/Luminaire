using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerGetScore : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inGetHourly_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inGetDaily_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inGetGlobal_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFinished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFailed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outInvalidQuestID_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outNotExist_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outMaintenance_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueTime_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueQuestId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueNumScores_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueStartIndex_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueOption_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueSetDefault_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueCacheUserScore_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueQuestNameID_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueNumScores_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueStartIndex_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueScores_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueNames_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueLevels_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueTitles_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueTitlesParam1_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueTitlesParam2_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueTitlesMessageParam1_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueTitlesMessageParam2_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueTitlesLabel_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueRanks_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueAccountId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueRate_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueUserRank_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueHour_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueMinute_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueSecond_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueMilliSecond_;
		public int numScores_;
		public bool isIndexDebugMode_;
		public int debugXb1Index_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerGetScore();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerGetScore", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerGetScore.ObjectType, null, properties, 0, 3608);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerGetScore", base.GetFieldProperties(), 1463761170, 501835363);
            
			
			
			return fieldProperties;
        }

		
    }
}