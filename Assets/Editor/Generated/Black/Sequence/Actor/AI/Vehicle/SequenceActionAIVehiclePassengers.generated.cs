using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Vehicle
{
    public partial class SequenceActionAIVehiclePassengers : Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin vehicleActor_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int target_;
		public int intValue_;
		public uint fixIdValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin intPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fixidPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIVehiclePassengers();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehiclePassengers", 0, Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehiclePassengers.ObjectType, null, properties, 0, 656);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehiclePassengers", base.GetFieldProperties(), -1658614061, 259292726);
            return fieldProperties;
        }

		
    }
}