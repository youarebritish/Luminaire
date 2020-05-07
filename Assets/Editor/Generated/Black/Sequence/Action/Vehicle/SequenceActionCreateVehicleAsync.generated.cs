using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionCreateVehicleAsync : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int locationType_;
		public int spawnType_;
		public int lifeSpanType_;
		public uint lifeTimeID_;
		public uint lifeWeatherID_;
		public bool actorCreateOne_;
		public bool useDummyActor_;
		public bool useLongRangeLOD0_;
		public bool ignoreManagerDisposeRequest_;
		public bool disposeIfImpossibleRunning_;
		public bool setInactiveAtSpawn_;
		public bool isSelectEntryDirectly_;
		public bool existPassenger_;
		public bool waitEntryLoading_;
		public uint bodyPatternId_;
		public uint passengerDeployId_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> charaEntryList_;
		public float distance_;
		public float range_;
		public bool isFrontOfBase_;
		public bool isSameLane_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin action_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin actionOut_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin createdActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inSpawnType_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inBaseActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inBasePosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inBaseRotate_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inDistance_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inRange_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inIsFrontOfBase_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inIsSameLane_;
		public bool waitAction_;
		public IList<Black.Sequence.Actor.AI.Vehicle.VehicleNavigationDestIdItem> destList_;
		public bool isLoopValue_;
		public int loopNumValue_;
		public bool isStopEngineAtEnd_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCreateVehicleAsync();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionCreateVehicleAsync", 0, Black.Sequence.Action.Vehicle.SequenceActionCreateVehicleAsync.ObjectType, null, properties, 0, 1696);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionCreateVehicleAsync", base.GetFieldProperties(), 202349935, 79500297);
            
			
			
			return fieldProperties;
        }

		
    }
}