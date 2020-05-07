using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Vehicle
{
    public partial class SequenceActionAIChocoboGetStatus : Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int target_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin floatPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin intPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin boolPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocoboPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIChocoboGetStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIChocoboGetStatus", 0, Black.Sequence.Actor.AI.Vehicle.SequenceActionAIChocoboGetStatus.ObjectType, null, properties, 0, 544);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIChocoboGetStatus", base.GetFieldProperties(), 223948166, 1862390001);
            
			
			
			return fieldProperties;
        }

		
    }
}