using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionPlayerVehicleNearestParkingPoint : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inPosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin vehicleActor_;
		public int target_;
		public bool isExecuteAreaRestart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failure_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin destId_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin position_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin rotation_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin direction_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin distance_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin bAreaRestartPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPlayerVehicleNearestParkingPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionPlayerVehicleNearestParkingPoint", 0, Black.Sequence.Action.Vehicle.SequenceActionPlayerVehicleNearestParkingPoint.ObjectType, null, properties, 0, 1248);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionPlayerVehicleNearestParkingPoint", base.GetFieldProperties(), -350275847, -2037131417);
            return fieldProperties;
        }

		
    }
}