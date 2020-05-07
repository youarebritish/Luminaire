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
            
			fieldProperties.AddProperty(new Property("start_", 3266844032, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("error_", 3860306698, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inputCreateTeam_", 1207420935, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inputDescentShip_", 2149145490, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inputOpenHatch_", 2449879636, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inputFinish_", 703142241, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inputForceFinish_", 3662183754, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inputSetModeSpecificPoint_", 1233795101, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 944, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inputSetModeSeedArea_", 2982507223, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1040, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("shipCreated_", 2199681778, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1136, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("shipArrived_", 2625169309, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1232, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("shipDescented_", 2587161979, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1328, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("canOpenHatch_", 624308670, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1424, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("shipFinished_", 1561926258, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1520, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("descentBlockedByRoad_", 2442069529, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1616, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("createdShipActor_", 1755380851, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1712, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("createdTeamActor_", 1888604596, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1800, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inputContinueRoute_", 1899613988, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1888, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("generatePosition_", 3408334998, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1984, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("generateRotation_", 85831053, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2072, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("shipId_", 647862967, "SQEX.Ebony.Std.Fixid", 2160, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("unitId_", 4148266991, "SQEX.Ebony.Std.Fixid", 2164, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("teamId_", 1186824794, "SQEX.Ebony.Std.Fixid", 2168, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoDeleteDistance_", 1081281987, "float", 2172, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("genrateAngleFromCameraBehind_", 1292583070, "float", 2176, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("generateDistanceFromCameraMin_", 925481987, "float", 2180, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("generateDistanceFromCameraMax_", 3452778345, "float", 2184, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("generateHeightFromGround_", 1593659951, "float", 2188, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("generateAtMaxSpeed_", 266868783, "bool", 2192, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isManualCreateTeam_", 4011277839, "bool", 2193, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isManualDescentShip_", 993996458, "bool", 2194, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isManualOpenHatch_", 1010877372, "bool", 2195, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("ignoreBattleArea_", 490314005, "bool", 2196, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("dynamicBattleAreaFixId_", 4276147486, "SQEX.Ebony.Std.Fixid", 2200, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("isOnRoadGlobalLabel_", 2569664122, "SQEX.Ebony.Std.Fixid", 2204, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("battleAreaSearchRadius_", 2295524477, "float", 2208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("groundSearchDistance_", 409722238, "float", 2212, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("destinationType_", 436116648, "Black.Actor.Component.Nifl.ReinforcementDestinationType", 2216, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("fixedDestinationPosition_", 3086384205, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2224, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fixedDestinationLookAt_", 586165582, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2312, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("reinforcementRouteIdPin_", 4035053110, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2400, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("reinforcementRouteId_", 3666144731, "SQEX.Ebony.Std.Fixid", 2488, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("disablePlayerWarp_", 64240517, "bool", 2492, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}