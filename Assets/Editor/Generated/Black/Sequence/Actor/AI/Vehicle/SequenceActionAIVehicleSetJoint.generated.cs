using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Vehicle
{
    public partial class SequenceActionAIVehicleSetJoint : Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inVehicleActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin intPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin floatPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin boolPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int target_;
		public int intValue_;
		public float floatValue_;
		public bool boolValue_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIVehicleSetJoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleSetJoint", 0, Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleSetJoint.ObjectType, null, properties, 0, 744);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleSetJoint", base.GetFieldProperties(), -2077261431, -1609847225);
            return fieldProperties;
        }

		
    }
}