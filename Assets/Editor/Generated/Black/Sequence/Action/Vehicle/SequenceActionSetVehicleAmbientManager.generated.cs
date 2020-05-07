using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionSetVehicleAmbientManager : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int target_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int category_;
		public bool boolValueCheck_;
		public bool needCameraCheck_;
		public uint areaId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin true_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin false_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin boolPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVehicleAmbientManager();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionSetVehicleAmbientManager", 0, Black.Sequence.Action.Vehicle.SequenceActionSetVehicleAmbientManager.ObjectType, null, properties, 0, 672);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionSetVehicleAmbientManager", base.GetFieldProperties(), 492403941, 1998045293);
            return fieldProperties;
        }

		
    }
}