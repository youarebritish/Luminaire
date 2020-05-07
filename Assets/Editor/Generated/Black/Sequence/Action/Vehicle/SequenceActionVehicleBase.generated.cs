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
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 360, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cancel_", 1679818508, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 456, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("vehicleActor_", 1082230137, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 552, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("frontRightSeat_", 448779664, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 640, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("frontLeftSeat_", 4239860617, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 728, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rearRightSeat_", 822775651, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 816, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rearCenterSeat_", 720807308, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 904, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rearLeftSeat_", 2617070720, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 992, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("passengerParamPin_", 1478059200, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1080, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorSwitchedPin_", 3305480735, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1168, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startPlayerStartPin_", 1307815438, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1264, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraTypePin_", 3854558638, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1360, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rideParameterPin_", 3392718862, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1448, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rideVehicleType_", 3995613574, "Black.Sequence.Action.Vehicle.SequenceActionVehicleBase.RIDE_TARGET", 1536, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("passengerParamID_", 237640246, "SQEX.Ebony.Std.Fixid", 1540, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("fromEventFlagPin_", 1846978157, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1544, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}