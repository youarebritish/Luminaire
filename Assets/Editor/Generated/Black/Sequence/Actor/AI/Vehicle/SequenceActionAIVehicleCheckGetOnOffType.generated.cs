using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Vehicle
{
    public partial class SequenceActionAIVehicleCheckGetOnOffType : Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inVehicleActor_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin allOpen_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin frontOnly_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin rearOnly_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin rightOnly_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin leftOnly_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIVehicleCheckGetOnOffType();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleCheckGetOnOffType", 0, Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleCheckGetOnOffType.ObjectType, null, properties, 0, 848);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleCheckGetOnOffType", base.GetFieldProperties(), 1078318505, -718428037);
            return fieldProperties;
        }

		
    }
}