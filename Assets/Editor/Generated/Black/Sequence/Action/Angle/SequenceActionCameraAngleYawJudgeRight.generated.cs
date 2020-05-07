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
            return fieldProperties;
        }

		
    }
}