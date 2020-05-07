using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Vehicle
{
    public partial class SequenceActionAIVehicleSetStatus : Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inVehicleActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin refActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin floatPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin boolPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin intPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int target_;
		public float floatValue_;
		public uint fixidValue_;
		public bool boolValue_;
		public int intValue_;
		public int envStateValue_;
		public float timeToUnfreeze_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIVehicleSetStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleSetStatus", 0, Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleSetStatus.ObjectType, null, properties, 0, 848);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleSetStatus", base.GetFieldProperties(), 611369481, -1138309891);
            return fieldProperties;
        }

		
    }
}