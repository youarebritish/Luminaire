using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Actor.Vehicle
{
    public partial class SequenceEventActorVehicleHeadLightStateChanged : Black.Sequence.Event.Actor.SequenceEventActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int signalType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventActorVehicleHeadLightStateChanged();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Actor.Vehicle.SequenceEventActorVehicleHeadLightStateChanged", 0, Black.Sequence.Event.Actor.Vehicle.SequenceEventActorVehicleHeadLightStateChanged.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Actor.Vehicle.SequenceEventActorVehicleHeadLightStateChanged", base.GetFieldProperties(), 791183447, 816365338);
            return fieldProperties;
        }

		
    }
}