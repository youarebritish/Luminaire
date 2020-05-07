using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionSetPlayerVehicleData : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fail_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin integerPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin positionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotationPin_;
		public int target_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetPlayerVehicleData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionSetPlayerVehicleData", 0, Black.Sequence.Action.Vehicle.SequenceActionSetPlayerVehicleData.ObjectType, null, properties, 0, 832);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionSetPlayerVehicleData", base.GetFieldProperties(), 1497778212, -2076969285);
            return fieldProperties;
        }

		
    }
}