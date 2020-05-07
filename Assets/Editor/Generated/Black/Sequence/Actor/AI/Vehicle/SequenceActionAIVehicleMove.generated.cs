using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Vehicle
{
    public partial class SequenceActionAIVehicleMove : Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin toStop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin finish_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin watchActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inVehicleActor_;
		public int target_;
		public bool isMoveFoward_;
		public bool isKeepLane_;
		public bool ignoreParkingCurve_;
		public float targetSpeed_;
		public float toStopTimeRange_;
		public float limitRange_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIVehicleMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleMove", 0, Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleMove.ObjectType, null, properties, 0, 864);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleMove", base.GetFieldProperties(), -233256154, 2064669584);
            return fieldProperties;
        }

		
    }
}