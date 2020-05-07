using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Vehicle
{
    public partial class SequenceActionAIVehicleGetStatus : Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin vehicleActor_;
		public int target_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin floatPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin boolPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin intPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin vectorPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIVehicleGetStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleGetStatus", 0, Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleGetStatus.ObjectType, null, properties, 0, 632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleGetStatus", base.GetFieldProperties(), 389511938, 1219245272);
            
			
			
			return fieldProperties;
        }

		
    }
}