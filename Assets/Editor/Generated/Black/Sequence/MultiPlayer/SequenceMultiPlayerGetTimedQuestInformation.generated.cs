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
            
			fieldProperties.AddProperty(new Property("inHourly_", 3163471772, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inDaily_", 3314114940, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inTotal_", 1134173853, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outSuccessed_", 3795751876, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outFailed_", 1514029807, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueQuestId_", 1189115767, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 656, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueTime_", 3376352291, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueIsEndReward_", 1035866163, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 832, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueEndingTime_", 554116635, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 920, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueStartingTime_", 2483505954, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1008, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueScoreType_", 1271538355, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1096, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueRuleId_", 3138100584, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1184, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueRuleArg_", 1064124319, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1272, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isLocalTime_", 2284894410, "bool", 1360, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}