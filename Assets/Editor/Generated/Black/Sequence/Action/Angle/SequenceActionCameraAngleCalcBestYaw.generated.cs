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
            
			
			
			return fieldProperties;
        }

		
    }
}