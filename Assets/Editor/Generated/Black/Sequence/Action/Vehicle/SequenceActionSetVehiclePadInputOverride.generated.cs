using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionSetVehiclePadInputOverride : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inAccelPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inBrakePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inIsAccelToBackwardPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inSteerPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inIsOverSteerPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inIsIceTirePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inOwnerActor_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVehiclePadInputOverride();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionSetVehiclePadInputOverride", 0, Black.Sequence.Action.Vehicle.SequenceActionSetVehiclePadInputOverride.ObjectType, null, properties, 0, 984);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionSetVehiclePadInputOverride", base.GetFieldProperties(), -892540178, 948949228);
            return fieldProperties;
        }

		
    }
}