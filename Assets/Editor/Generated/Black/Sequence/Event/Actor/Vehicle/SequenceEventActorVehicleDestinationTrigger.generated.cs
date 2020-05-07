using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Actor.Vehicle
{
    public partial class SequenceEventActorVehicleDestinationTrigger : Black.Sequence.Event.Actor.SequenceEventActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public uint destId_;
		public int target_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventActorVehicleDestinationTrigger();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Actor.Vehicle.SequenceEventActorVehicleDestinationTrigger", 0, Black.Sequence.Event.Actor.Vehicle.SequenceEventActorVehicleDestinationTrigger.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Actor.Vehicle.SequenceEventActorVehicleDestinationTrigger", base.GetFieldProperties(), -256047756, 638479065);
            return fieldProperties;
        }

		
    }
}