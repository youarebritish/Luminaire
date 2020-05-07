using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Actor.Vehicle
{
    public partial class SequenceEventActorVehicleStateChanged : Black.Sequence.Event.Actor.SequenceEventActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int target_;
		public int condition_;
		public bool isCondition_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin paramOnePin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventActorVehicleStateChanged();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Actor.Vehicle.SequenceEventActorVehicleStateChanged", 0, Black.Sequence.Event.Actor.Vehicle.SequenceEventActorVehicleStateChanged.ObjectType, null, properties, 0, 408);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Actor.Vehicle.SequenceEventActorVehicleStateChanged", base.GetFieldProperties(), -1950462685, 783406195);
            return fieldProperties;
        }

		
    }
}