using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.SceneControl
{
    public partial class SequenceActionSCActorCreate : Black.Sequence.Actor.SequenceActionActorCreateBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin abortInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin recoverInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin recoverStopPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin eachSpawned_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin allSpawned_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin recoverSuccess_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin position_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spawnPointPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spawnSets_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin spawnedList_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin lastSpawnedList_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin lastSpawned_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin lastRecovered_;
		public int spawnPointType_;
		public float spawnRadius_;
		public bool isUseEachBlackPathNodeRadius_;
		public int retryCountWhenRadius_;
		public int retryLimitRayCheckNGCount_;
		public string teamName_;
		public string teamType_;
		public uint teamNameId_;
		public uint teamTypeId_;
		public uint teamParamID_;
		public uint tacticsID_;
		public string teamAIPath_;
		public int roleSetType_;
		public bool bAutoTeamMerge_;
		public int spawnWeightType1_;
		public int spawnWeightType2_;
		public int spawnWeightType3_;
		public float spawnPointWeightThreshhold_;
		public float spawnPointSamePointWeightImpact_;
		public float afterSpawnWaitTime_;
		public bool isDeathActorRecover_;
		public int m_SceneNoWhenActivated;
		public bool m_bIsScriptActivated;
		public int m_SelectRotationType;
		public int autoRandomYawMin_;
		public int autoRandomYawMax_;
		public float TimeBetweenPawnSpawns;
		public float MinTimeBetweenPawnSpawns;
		public bool isIKRayCheck_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSCActorCreate();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SceneControl.SequenceActionSCActorCreate", 0, Black.Sequence.Action.Actor.SceneControl.SequenceActionSCActorCreate.ObjectType, null, properties, 0, 2928);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SceneControl.SequenceActionSCActorCreate", base.GetFieldProperties(), 860672597, -1426692639);
            
			fieldProperties.AddProperty(new Property("abortInputPin_", 2208040203, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 992, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("recoverInputPin_", 4225503605, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1088, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("recoverStopPin_", 947002943, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("finished_", 3052293812, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("failed_", 2601209585, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1376, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("eachSpawned_", 3523267979, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1472, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("allSpawned_", 39806079, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1568, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("recoverSuccess_", 2909986171, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1664, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotation_", 36328192, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1760, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("position_", 987254735, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1848, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnPointPin_", 1892548174, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1936, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnSets_", 3387597386, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2024, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnedList_", 444517422, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2112, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastSpawnedList_", 818520474, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2200, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastSpawned_", 1271405358, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2288, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastRecovered_", 641796059, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2376, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnPointType_", 396215139, "Black.Sequence.Action.Actor.SceneControl.SequenceActionSCActorCreate.BlackScene_SpawnPointType", 2464, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnRadius_", 3103806531, "float", 2468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseEachBlackPathNodeRadius_", 1295424010, "bool", 2472, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("retryCountWhenRadius_", 2515786595, "int", 2476, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("retryLimitRayCheckNGCount_", 2205151023, "int", 2480, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("teamName_", 420023592, "String", 2488, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("teamType_", 2338914273, "String", 2504, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("teamNameId_", 3429166287, "SQEX.Ebony.Std.Fixid", 2520, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("teamTypeId_", 2714556450, "SQEX.Ebony.Std.Fixid", 2524, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("teamParamID_", 2539395461, "SQEX.Ebony.Std.Fixid", 2528, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("tacticsID_", 3694897068, "SQEX.Ebony.Std.Fixid", 2532, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("teamAIPath_", 1220123010, "String", 2536, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("roleSetType_", 3015812344, "Black.AI.Role.ROLE_SET_TYPE", 2552, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("bAutoTeamMerge_", 3975854846, "bool", 2556, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnWeightType1_", 3174420292, "Black.Sequence.Action.Actor.SceneControl.SequenceActionSCActorCreate.BlackScene_SpawnWeightType", 2592, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnWeightType2_", 2100902939, "Black.Sequence.Action.Actor.SceneControl.SequenceActionSCActorCreate.BlackScene_SpawnWeightType", 2596, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnWeightType3_", 2101050034, "Black.Sequence.Action.Actor.SceneControl.SequenceActionSCActorCreate.BlackScene_SpawnWeightType", 2600, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnPointWeightThreshhold_", 48122602, "float", 2604, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnPointSamePointWeightImpact_", 3877895865, "float", 2608, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("afterSpawnWaitTime_", 3601977937, "float", 2612, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isDeathActorRecover_", 3793201371, "bool", 2616, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_SceneNoWhenActivated", 2815888975, "int", 2664, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_bIsScriptActivated", 3927967661, "bool", 2672, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("m_SelectRotationType", 1041771327, "Black.Sequence.Action.Actor.SceneControl.SequenceActionSCActorCreate.EBlackSCSpawnRotationType", 2696, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoRandomYawMin_", 2994305093, "int", 2700, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoRandomYawMax_", 1500376407, "int", 2704, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("TimeBetweenPawnSpawns", 4208714558, "float", 2860, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("MinTimeBetweenPawnSpawns", 2573875488, "float", 2864, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isIKRayCheck_", 3331595810, "bool", 2868, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}