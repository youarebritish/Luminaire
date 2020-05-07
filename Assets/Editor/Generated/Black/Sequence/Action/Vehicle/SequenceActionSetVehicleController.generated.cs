using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionSetVehicleController : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int category_;
		public bool isEnableAccel_;
		public bool isEnableBrake_;
		public bool isEnableHandle_;
		public bool isEnableGetOff_;
		public bool isEnableCamera_;
		public bool isEnableMusic_;
		public bool isEnableRoof_;
		public bool isEnableKlaxon_;
		public bool isEnableUturn_;
		public bool isEnableAutoSave_;
		public bool isEnableDriveMenu_;
		public bool isEnableWaitGetoff_;
		public bool isEnableCameraRoll_;
		public bool isEnableTakeOff_;
		public bool isEnableJump_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVehicleController();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionSetVehicleController", 0, Black.Sequence.Action.Vehicle.SequenceActionSetVehicleController.ObjectType, null, properties, 0, 392);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionSetVehicleController", base.GetFieldProperties(), 85366092, -1165584175);
            
			
			
			return fieldProperties;
        }

		
    }
}