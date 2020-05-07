using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Angle
{
    public partial class SequenceActionCameraAngleCalcBestYaw : Black.Sequence.Action.Angle.SequenceActionCameraAngleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin judgePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin clearPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin matrixPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin offsetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin focusPlusSignPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin distancePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin allowDistancePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnYawPlusSignPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnYawAddDegPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnYawPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnTiltAddDegPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnTiltPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin bestYawPin_;
		public int checkCollisionType_;
		public bool isUseHeightRate_;
		public float hightRate_;
		public float defaultHightOffset_;
		public float checkDistance_;
		public float allowDistance_;
		public int useMatrixType_;
		public UnityEngine.Vector4 offset_;
		public bool plusSign_;
		public float rayCheckEachAngle_;
		public int rayCheckNum_;
		public int addMarginNumFromBestAngle_;
		public bool isNeedCalcWheneverGet_;
		public float updateYawAccel_;
		public int bestAngleJudgeType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraAngleCalcBestYaw();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Angle.SequenceActionCameraAngleCalcBestYaw", 0, Black.Sequence.Action.Angle.SequenceActionCameraAngleCalcBestYaw.ObjectType, null, properties, 0, 2656);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Angle.SequenceActionCameraAngleCalcBestYaw", base.GetFieldProperties(), 1851781962, -1145413443);
            
			fieldProperties.AddProperty(new Property("judgePin_", 955830756, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("clearPin_", 2510457522, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPin_", 2732252299, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetPin_", 4111270248, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("matrixPin_", 1650836828, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1552, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetPin_", 3742051434, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1640, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("focusPlusSignPin_", 2903705842, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1728, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("distancePin_", 3376150770, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1816, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("allowDistancePin_", 946110373, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1904, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnYawPlusSignPin_", 185187356, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1992, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnYawAddDegPin_", 4201173072, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2080, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnYawPin_", 1143598217, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2168, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnTiltAddDegPin_", 2978613404, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2256, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnTiltPin_", 3019476029, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2344, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bestYawPin_", 1480390034, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2432, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkCollisionType_", 2944079722, "Black.Camera.CheckCollisionType", 2520, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseHeightRate_", 3312106470, "bool", 2524, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("hightRate_", 498403466, "float", 2528, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("defaultHightOffset_", 3196377474, "float", 2532, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkDistance_", 3872236269, "float", 2536, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("allowDistance_", 3943245842, "float", 2540, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("useMatrixType_", 2102416110, "Black.Sequence.Operator.Calculate.SequenceOperatorCalculateMatrixTransformCoord.PresetMatrixType", 2544, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("offset_", 1294275471, "SQEX.Luminous.Math.VectorA", 2560, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("plusSign_", 2337032721, "bool", 2576, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rayCheckEachAngle_", 3498938008, "float", 2580, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rayCheckNum_", 2837094368, "int", 2584, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("addMarginNumFromBestAngle_", 3038749808, "int", 2588, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNeedCalcWheneverGet_", 1461533285, "bool", 2592, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("updateYawAccel_", 879490218, "float", 2596, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("bestAngleJudgeType_", 492051394, "Black.Camera.BestAngleJudgeType", 2600, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}