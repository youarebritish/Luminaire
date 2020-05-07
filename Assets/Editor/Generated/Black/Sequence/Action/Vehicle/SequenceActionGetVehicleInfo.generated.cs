using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionGetVehicleInfo : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inVehicleActor_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outForwardSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outSideSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outRotate_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outPosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outIsRoofOpened_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outIsWindowOpened_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetVehicleInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionGetVehicleInfo", 0, Black.Sequence.Action.Vehicle.SequenceActionGetVehicleInfo.ObjectType, null, properties, 0, 1072);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionGetVehicleInfo", base.GetFieldProperties(), 469330067, 611305231);
            return fieldProperties;
        }

		
    }
}