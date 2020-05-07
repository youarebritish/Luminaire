using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionVehicleBase : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin cancel_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin vehicleActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frontRightSeat_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frontLeftSeat_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rearRightSeat_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rearCenterSeat_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rearLeftSeat_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin passengerParamPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin actorSwitchedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin startPlayerStartPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cameraTypePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin rideParameterPin_;
		public int rideVehicleType_;
		public uint passengerParamID_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fromEventFlagPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionVehicleBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionVehicleBase", 0, Black.Sequence.Action.Vehicle.SequenceActionVehicleBase.ObjectType, null, properties, 0, 1736);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionVehicleBase", base.GetFieldProperties(), -319800147, 383098697);
            
			
			
			return fieldProperties;
        }

		
    }
}