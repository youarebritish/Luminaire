using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Angle
{
    public partial class SequenceActionCameraAngleYawJudgeRight : Black.Sequence.Action.Angle.SequenceActionCameraAngleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin judgePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin clearPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin preOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin leftOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin rightOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin badOutPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin basePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin checkCollisionTargetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin checkDirectionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin initialIsRightPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin IsRightPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cutChangePin_;
		public bool isJudge_;
		public bool isUseBasePC_;
		public bool isUseTargetCurrentCamera_;
		public bool isCheckSideByCollision_;
		public float checkCollisionBaseHeight_;
		public float checkCollisionMargin_;
		public float checkCollisionLength_;
		public float checkCollisionWidth_;
		public float checkCollisionHeight_;
		public bool isDontActivateOutPinWhenBadSituation_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraAngleYawJudgeRight();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Angle.SequenceActionCameraAngleYawJudgeRight", 0, Black.Sequence.Action.Angle.SequenceActionCameraAngleYawJudgeRight.ObjectType, null, properties, 0, 2592);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Angle.SequenceActionCameraAngleYawJudgeRight", base.GetFieldProperties(), 800784702, -2118788773);
            
			fieldProperties.AddProperty(new Property("judgePin_", 955830756, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("clearPin_", 2510457522, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("preOutPin_", 1744652298, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPin_", 2732252299, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("leftOutPin_", 3180113460, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rightOutPin_", 3192523915, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("badOutPin_", 712778156, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetPin_", 4111270248, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1848, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("basePin_", 905055864, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1936, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkCollisionTargetPin_", 1156266684, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2024, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkDirectionPin_", 3554172640, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2112, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("initialIsRightPin_", 1582996415, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2200, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsRightPin_", 3740470017, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2288, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cutChangePin_", 2245977347, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2376, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isJudge_", 2446576337, "bool", 2464, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseBasePC_", 583811197, "bool", 2465, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseTargetCurrentCamera_", 2598077338, "bool", 2466, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCheckSideByCollision_", 2067801348, "bool", 2467, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkCollisionBaseHeight_", 722191672, "float", 2468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkCollisionMargin_", 3717274648, "float", 2472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkCollisionLength_", 3827109114, "float", 2476, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkCollisionWidth_", 1135784196, "float", 2480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkCollisionHeight_", 2274542755, "float", 2484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isDontActivateOutPinWhenBadSituation_", 2140393734, "bool", 2488, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}