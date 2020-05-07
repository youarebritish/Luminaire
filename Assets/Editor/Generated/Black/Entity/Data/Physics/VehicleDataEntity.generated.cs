using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Physics
{
    public partial class VehicleDataEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint entryId_;
		public int vehicleType_;
		public float enginePeakTorque_;
		public float engineMaxRotationSpeed_;
		public IList<Black.Entity.Data.Physics.VehicleTorqueCurveDataItem> torqueCurve_;
		public float frontBrakeTorque_;
		public float rearBrakeTorque_;
		public float frontHandBrakeTorque_;
		public float rearHandBrakeTorque_;
		public float frontMaxSteer_;
		public float rearMaxSteer_;
		public IList<Black.Entity.Data.Physics.VehicleSteeringPerSpeedCurveDataItem> steerPerSpeedCurve_;
		public float frontMaxSteerUTurn_;
		public float rearMaxSteerUTurn_;
		public float suspensionMaxCompression_;
		public float suspensionMaxDroop_;
		public float suspensionSpringStrength_;
		public float suspensionSpringDamperRate_;
		public float suspensionSpringDamperRateRear_;
		public float suspensionAdditionalRaycastLength_;
		public float suspensionMaxCompressionLimit_;
		public float suspensionMaxDroopLimit_;
		public float suspMaxDisplacement_;
		public bool bNeedKineDriverUpdate_;
		public int differentialType_;
		public IList<Black.Entity.Data.Physics.VehicleGearDataItem> gearData_;
		public float gearFinalRatio_;
		public float gearSwitchTime_;
		public float clutchStrength_;
		public uint frontTireId_;
		public uint rearTireId_;
		public float maxTargetSpeed_;
		public float targetSpeedRevisionRate_;
		public float targetSpeedRevisionAdd_;
		public float checkTargetSpeedMargin_;
		public float checkTargetSteerMargin_;
		public float switchAssistDriveTime_;
		public float maxApproachAngle_;
		public float maxAutoApproachAngle_;
		public float maxApproachDeltaWidth_;
		public float targetLeftLane_;
		public float maxLeftLane_;
		public bool isUsePassing_;
		public float startPassingDeltaSpeed_;
		public float startPassingLowSpeed_;
		public float followBehindDistance_;
		public float followBehindDistanceOnStopped_;
		public float blendRateSteer_;
		public float blendRateAccelBrake_;
		public float yOffsetOnLod1_;
		public float assistOffsetZ_;
		public float minSpeedForHuman_;
		public float switchManualToAutoDriveTime_;
		public float delayTimeReSearchPathWhenVehicleLeavePath_;
		public float timeIntervalSearchPathWhenReverseRun_;
		public bool isUseTireJoint_;
		public bool isRearTireFour_;
		public bool isUseHandleJoint_;
		public bool isUseMeterJoint_;
		public bool isUseWindowJoint_;
		public float frontWindowOpeningWidth_;
		public float rearWindowOpeningWidth_;
		public float fonrtWindowPillarOpeningWidth_;
		public bool isUpdateIdleMotion_;
		public bool isCheckChangeMotion_;
		public uint openMotionId_;
		public uint closeMotionId_;
		public uint startWiperMotionId_;
		public uint stopWiperMotionId_;
		public uint openEngineCoverMotionId_;
		public uint closeEngineCoverMotionId_;
		public int allCoverBonnetBBValue_;
		public int leftEngineCoverBBValue_;
		public int rightEngineCoverBBValue_;
		public int leftBonnetBBValue_;
		public int rightBonnetBBValue_;
		public uint openBonnetMotionId_;
		public uint closeBonnetMotionId_;
		public bool useFuelConsumption_;
		public float fuelTank_;
		public float fuelConsumption_;
		public bool isUseProcedualSound_;
		public int procedualSoundPriority_;
		public uint soundId_;
		public uint soundGroundId_;
		public uint soundWeatherId_;
		public uint soundContactId_;
		public uint soundEngineSimulateId_;
		public float engineLoopStartFade_;
		public float engineLoopStopFade_;
		public float engineLoopPitchMin_;
		public float engineLoopPitchMax_;
		public float engineLoopVolumeMin_;
		public float engineLoopVolumeMax_;
		public float brakeDecelerationMax_;
		public float brakeVolumeMin_;
		public float brakeVolumeMax_;
		public float tireLoopSpeedMax_;
		public float tireLoopPitchMin_;
		public float tireLoopPitchMax_;
		public float tireLoopVolumeMin_;
		public float tireLoopVolumeMax_;
		public float turnLoopSpeedMax_;
		public float turnLoopAbsSpeedMin_;
		public float turnLoopAbsSpeedMax_;
		public float turnLoopPitchMin_;
		public float turnLoopPitchMax_;
		public float turnLoopVolumeMin_;
		public float turnLoopVolumeMax_;
		public float suspensionVolumeMin_;
		public float suspensionVolumeMax_;
		public float suspensionForceMin_;
		public float suspensionForceMax_;
		public bool isUseVfx_;
		public uint vfxId_;
		public uint vfxGroundId_;
		public uint vfxWeatherId_;
		public uint vfxMarkWeatherId_;
		public uint vfxFoliageId_;
		public bool isUseMaterial_;
		public uint materialId_;
		public uint materialWeatherSetId_;
		public uint materialContactSetId_;
		public uint materialCustomizeSetId_;
		public uint materialTransformedId_;
		public float frontTireRadius_;
		public float frontTireWidth_;
		public float rearTireRadius_;
		public float rearTireWidth_;
		public UnityEngine.Vector4 frontTireOffset_;
		public UnityEngine.Vector4 rearTireOffset_;
		public UnityEngine.Vector4 frontTireDrawOffset_;
		public UnityEngine.Vector4 rearTireDrawOffset_;
		public float chassisWidth_;
		public float chassisHeight_;
		public float chassisDepth_;
		public UnityEngine.Vector4 chassisOffset_;
		public UnityEngine.Vector4 chassisCMOffset_;
		public float chassisRoofHeight_;
		public float chassisRoofDepthFromFront_;
		public float chassisRoofDepthFromRear_;
		public float chassisFrontBumperDepth_;
		public float chassisFrontBumperFromSide_;
		public float chassisRearBumperDepth_;
		public float chassisRearDumperFromSide_;
		public float chassisRoofExtraHeight_;
		public float chassisBottomHeight_;
		public float chassisBottomDepressionSide_;
		public float chassisBottomDepressionDepth_;
		public float rigidBodyScale_;
		public int characterSize_;
		public float chassisMass_;
		public float wheelMass_;
		public uint shipParamId_;
		public bool useOceanWave_;
		public float waveNormalRate_;
		public float waveNormalRateOfMaxSpeed_;
		public float nextDirRate_;
		public float nextRotRate_;
		public float lengthToBow_;
		public float offsetCOMOfmaxSpeed_;
		public float freeFallHeight_;
		public float airResistent_;
		public float waterResistentFoward_;
		public float waterResistentCenter_;
		public UnityEngine.Vector4 angularCoverageTime_;
		public UnityEngine.Vector4 angularSpeedResistance_;
		public float maxRollAngle_;
		public float beginAvoidDistance_;
		public float endAvoidDistance_;
		public float targetAvoidLane_;
		public float whileAvoidSpeed_;
		public float maxDeltaMoveLane_;
		public float shipPitchPower_;
		public IList<Black.Entity.WaterExclusionBoxParameter> waterExclusionBoxParams_;
		public float skiParamTorqueForSteering1_;
		public float skiParamTorqueForSteering2_;
		public bool isEnableFreeDrive_;
		public float yawRotationSpeedInAir_;
		public uint vehicleSpeedByGroundAttribute_;
		public uint freeDriveAttackSetId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VehicleDataEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Physics.VehicleDataEntity", 0, Black.Entity.Data.Physics.VehicleDataEntity.ObjectType, null, properties, 0, 960);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Physics.VehicleDataEntity", base.GetFieldProperties(), 739638239, 1992925650);
            
			
			
			return fieldProperties;
        }

		
    }
}