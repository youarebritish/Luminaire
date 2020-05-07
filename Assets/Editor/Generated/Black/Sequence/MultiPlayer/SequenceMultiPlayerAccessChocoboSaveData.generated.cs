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
            
			fieldProperties.AddProperty(new Property("inGet_", 3188819951, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inSet_", 608539611, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inAdd_", 552830470, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inAddChocobo_", 1631739059, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inEnableChocoboDebugGet_", 4128708540, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outSucceeded_", 929902953, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outFailed_", 1514029807, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueIndex_", 4080275598, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 944, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueNameId_", 3981562474, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1032, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValuePersonality_", 3552443690, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1120, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueRarity_", 661686409, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1208, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueColor_", 4113403427, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1296, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueStamina_", 4145881849, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1384, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueJump_", 4148115036, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueSpeed_", 2764623999, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1560, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueSkillLevel_", 1494859919, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1648, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueLimitMaxLevel_", 2483070823, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1736, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueMaxLevel_", 198604328, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1824, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueLevel_", 2505392448, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1912, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inValueInjuryPercent_", 3013632654, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2000, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueNameId_", 2724876039, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2088, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValuePersonality_", 4205178509, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueRarity_", 984188808, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2264, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueColor_", 590853996, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2352, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueStamina_", 4086882658, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2440, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueJump_", 3534910925, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueSpeed_", 3308095808, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2616, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueSkillLevel_", 838088042, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2704, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueLimitMaxLevel_", 621257264, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2792, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueMaxLevel_", 1209608701, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2880, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueLevel_", 2666265327, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2968, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueInjuryPercent_", 104703957, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 3056, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueChocoboNum_", 227847412, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 3144, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outValueExistLevel99_", 2458345834, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 3232, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}