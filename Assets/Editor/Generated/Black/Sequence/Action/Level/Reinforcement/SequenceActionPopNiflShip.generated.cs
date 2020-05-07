using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Reinforcement
{
    public partial class SequenceActionPopNiflShip : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin start_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin error_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inputCreateTeam_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inputDescentShip_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inputOpenHatch_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inputFinish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inputForceFinish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inputSetModeSpecificPoint_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inputSetModeSeedArea_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin shipCreated_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin shipArrived_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin shipDescented_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin canOpenHatch_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin shipFinished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin descentBlockedByRoad_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin createdShipActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin createdTeamActor_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inputContinueRoute_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin generatePosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin generateRotation_;
		public uint shipId_;
		public uint unitId_;
		public uint teamId_;
		public float autoDeleteDistance_;
		public float genrateAngleFromCameraBehind_;
		public float generateDistanceFromCameraMin_;
		public float generateDistanceFromCameraMax_;
		public float generateHeightFromGround_;
		public bool generateAtMaxSpeed_;
		public bool isManualCreateTeam_;
		public bool isManualDescentShip_;
		public bool isManualOpenHatch_;
		public bool ignoreBattleArea_;
		public uint dynamicBattleAreaFixId_;
		public uint isOnRoadGlobalLabel_;
		public float battleAreaSearchRadius_;
		public float groundSearchDistance_;
		public int destinationType_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fixedDestinationPosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fixedDestinationLookAt_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin reinforcementRouteIdPin_;
		public uint reinforcementRouteId_;
		public bool disablePlayerWarp_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPopNiflShip();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Reinforcement.SequenceActionPopNiflShip", 0, Black.Sequence.Action.Level.Reinforcement.SequenceActionPopNiflShip.ObjectType, null, properties, 0, 2736);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Reinforcement.SequenceActionPopNiflShip", base.GetFieldProperties(), 2139009608, 1676447873);
            return fieldProperties;
        }

		
    }
}