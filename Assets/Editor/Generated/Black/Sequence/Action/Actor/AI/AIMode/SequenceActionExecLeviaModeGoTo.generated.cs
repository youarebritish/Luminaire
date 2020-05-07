using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionExecLeviaModeGoTo : Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actionTypeIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetPointIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin homingOffsetRotationIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin bodyMessageIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin angularVelocityYawIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin angularVelocityPitchIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin movingHeightOffsetIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moveSpeedMinIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moveSpeedMaxIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin distanceThresholdRelayIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin relayBezierDistanceRateIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin relayDistanceRateIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin tangentLengthOfBezierCurveIPin_;
		public int actionType_;
		public uint bodyMessage_;
		public bool isResetMoveSpeed_;
		public bool notInverseTurn_;
		public float angularVelocityYaw_;
		public float angularVelocityPitch_;
		public float movingHeightOffset_;
		public float distanceThresholdRelay_;
		public float relayBezierDistanceRate_;
		public float relayDistanceRate_;
		public float tangentLengthOfBezierCurve_;
		public float timeOut_;
		public bool isHomingMode_;
		public UnityEngine.Vector4 homingOffsetRotation_;
		public bool isOverwriteMovement_;
		public float moveSpeedMin_;
		public float moveSpeedMax_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecLeviaModeGoTo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecLeviaModeGoTo", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecLeviaModeGoTo.ObjectType, null, properties, 0, 2560);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecLeviaModeGoTo", base.GetFieldProperties(), 1896495122, 1906994913);
            return fieldProperties;
        }

		
    }
}