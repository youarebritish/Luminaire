using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionPlayerVehicleCondition : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin true_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin false_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inVehicleActor_;
		public int condition_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPlayerVehicleCondition();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionPlayerVehicleCondition", 0, Black.Sequence.Action.Vehicle.SequenceActionPlayerVehicleCondition.ObjectType, null, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionPlayerVehicleCondition", base.GetFieldProperties(), -554861250, 1659209799);
            return fieldProperties;
        }

		
    }
}