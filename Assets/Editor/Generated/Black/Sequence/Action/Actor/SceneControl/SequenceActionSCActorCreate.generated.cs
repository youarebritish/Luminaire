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
            
			
			
			return fieldProperties;
        }

		
    }
}