using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Actor.Vehicle
{
    public partial class SequenceEventActorVehicleGetOff : Black.Sequence.Event.Actor.SequenceEventActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int target_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventActorVehicleGetOff();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Actor.Vehicle.SequenceEventActorVehicleGetOff", 0, Black.Sequence.Event.Actor.Vehicle.SequenceEventActorVehicleGetOff.ObjectType, null, properties, 0, 288);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Actor.Vehicle.SequenceEventActorVehicleGetOff", base.GetFieldProperties(), 1214803585, -434806535);
            return fieldProperties;
        }

		
    }
}