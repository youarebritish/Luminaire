using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Vehicle
{
    public partial class SequenceActionCreatePlayerVehicle : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin createdVehicle_;
		public bool isSetTranslate_;
		public bool isOverwriteLoadData_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spawnPointPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin position_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotation_;
		public bool isUseRayCheck_;
		public float upperExtentOffset_;
		public float lowerExtentOffset_;
		public bool isSetVehicleType_;
		public int vehicleType_;
		public bool isDisposePreviewVehicle_;
		public bool isSetKinematic_;
		public bool isUpdateSaveData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCreatePlayerVehicle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Vehicle.SequenceActionCreatePlayerVehicle", 0, Black.Sequence.Actor.AI.Vehicle.SequenceActionCreatePlayerVehicle.ObjectType, null, properties, 0, 944);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Vehicle.SequenceActionCreatePlayerVehicle", base.GetFieldProperties(), 1034165509, -1145636349);
            
			
			
			return fieldProperties;
        }

		
    }
}