using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorMoveOnRail : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin stopped_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinMovingActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinAccel_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinInitPos_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinMesh_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinShouldMoveTerrain_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPinIdxBaselineCart_;
		public int movementType_;
		public float searchRadius_;
		public float speedKiloMeterPerHour_;
		public float maxAccelKmPerHourPerSec_;
		public bool autoFindNextCurve_;
		public float rollMaxDegree_;
		public float rollScale_;
		public float vibrationMaxX_;
		public float vibrationMaxY_;
		public float vibrationFreq_;
		public float vibrationDuration_;
		public int timerType_;
		public int idxBaselineCart_;
		public bool isDebuggingCurvature_;
		public bool isBogieFittingDisabled_;
		public bool isConnectorAnimDisabled_;
		public bool isRollingDisabled_;
		public bool isVibrationDisabled_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorMoveOnRail();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorMoveOnRail", 0, Black.Sequence.Actor.SequenceActionActorMoveOnRail.ObjectType, null, properties, 0, 1408);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorMoveOnRail", base.GetFieldProperties(), -1524574949, -2111661878);
            
			
			
			return fieldProperties;
        }

		
    }
}