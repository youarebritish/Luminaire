using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionGetVehicleImpossibleRunningStatus : Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inVehicleActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin checkTimePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outTrue_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFalse_;
		public int target_;
		public float checkTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetVehicleImpossibleRunningStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionGetVehicleImpossibleRunningStatus", 0, Black.Sequence.Action.Vehicle.SequenceActionGetVehicleImpossibleRunningStatus.ObjectType, null, properties, 0, 656);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionGetVehicleImpossibleRunningStatus", base.GetFieldProperties(), 1734364911, -1628166973);
            return fieldProperties;
        }

		
    }
}