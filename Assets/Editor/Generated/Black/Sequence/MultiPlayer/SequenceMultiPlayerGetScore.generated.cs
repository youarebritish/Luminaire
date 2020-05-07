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
            
			fieldProperties.AddProperty(new Property("inGetHourly_", 298286912, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inGetDaily_", 1903655376, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inGetGlobal_", 4112601534, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outFinished_", 3334032594, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outFailed_", 1514029807, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outInvalidQuestID_", 1667423110, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outNotExist_", 2936277172, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outMaintenance_", 2749317755, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 944, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueTime_", 3376352291, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1040, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueQuestId_", 1189115767, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1128, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueNumScores_", 2741424607, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1216, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueStartIndex_", 3787407884, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1304, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueOption_", 69847759, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1392, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueSetDefault_", 4292007091, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1480, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueCacheUserScore_", 569328935, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueQuestNameID_", 2420284365, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1656, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueNumScores_", 3486984936, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueStartIndex_", 2730843985, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1832, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueScores_", 728869784, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1920, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueNames_", 1176872305, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2008, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueLevels_", 2637568460, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2096, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueTitles_", 1639510868, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueTitlesParam1_", 938221236, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueTitlesParam2_", 938368331, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueTitlesMessageParam1_", 3016945459, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2448, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueTitlesMessageParam2_", 3016798364, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2536, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueTitlesLabel_", 1259314748, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2624, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueRanks_", 3089161452, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2712, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueAccountId_", 3304385067, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2800, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueRate_", 3916901531, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2888, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueUserRank_", 844757534, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2976, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueHour_", 1098485999, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 3064, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueMinute_", 2459629025, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 3152, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueSecond_", 2297177389, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 3240, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueMilliSecond_", 3948590206, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 3328, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("numScores_", 2387525617, "unsigned int", 3416, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("isIndexDebugMode_", 3803702578, "bool", 3420, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("debugXb1Index_", 654777100, "unsigned int", 3424, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}