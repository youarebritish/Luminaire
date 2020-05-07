using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionSetVehicleParam : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public float chassisMass_;
		public float wheelMass_;
		public int frontTireType_;
		public int rearTireType_;
		public float frontBrakeTorque_;
		public float rearBrakeTorque_;
		public float frontHandBrakeTorque_;
		public float rearHandBrakeTorque_;
		public float frontMaxSteer_;
		public float rearMaxSteer_;
		public float suspensionShimHeight_;
		public float suspentionMaxCompression_;
		public float suspentionMaxDroop_;
		public float suspentionSpringStrength_;
		public float suspentionSpringDamperRate_;
		public float enginePeakTorque_;
		public float engineMaxRotationSpeed_;
		public float accelOffSpeed_;
		public int differentialType_;
		public float gearsSwitchTime_;
		public float gearsRatioR_;
		public float gearsRatio1_;
		public float gearsRatio2_;
		public float gearsRatio3_;
		public float gearsRatio4_;
		public float gearsRatio5_;
		public float autoGearsUpRatioR_;
		public float autoGearsUpRatioN_;
		public float autoGearsUpRatio1_;
		public float autoGearsUpRatio2_;
		public float autoGearsUpRatio3_;
		public float autoGearsUpRatio4_;
		public float autoGearsDownRatio1_;
		public float autoGearsDownRatio2_;
		public float autoGearsDownRatio3_;
		public float autoGearsDownRatio4_;
		public float autoGearsDownRatio5_;
		public float clutchStrength_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVehicleParam();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionSetVehicleParam", 0, Black.Sequence.Action.Vehicle.SequenceActionSetVehicleParam.ObjectType, null, properties, 0, 520);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionSetVehicleParam", base.GetFieldProperties(), 1933791690, -1436126389);
            return fieldProperties;
        }

		
    }
}