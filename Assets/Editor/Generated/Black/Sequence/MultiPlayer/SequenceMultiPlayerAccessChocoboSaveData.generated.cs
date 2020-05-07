using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerAccessChocoboSaveData : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inGet_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inSet_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inAdd_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inAddChocobo_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inEnableChocoboDebugGet_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outSucceeded_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFailed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueIndex_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueNameId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValuePersonality_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueRarity_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueStamina_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueJump_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueSkillLevel_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueLimitMaxLevel_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueMaxLevel_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueLevel_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueInjuryPercent_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueNameId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValuePersonality_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueRarity_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueStamina_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueJump_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueSkillLevel_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueLimitMaxLevel_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueMaxLevel_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueLevel_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueInjuryPercent_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueChocoboNum_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueExistLevel99_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerAccessChocoboSaveData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerAccessChocoboSaveData", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerAccessChocoboSaveData.ObjectType, null, properties, 0, 3408);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerAccessChocoboSaveData", base.GetFieldProperties(), -430809096, 1687405613);
            return fieldProperties;
        }

		
    }
}