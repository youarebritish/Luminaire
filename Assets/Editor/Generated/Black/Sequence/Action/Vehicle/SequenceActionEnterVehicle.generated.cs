using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionEnterVehicle : Black.Sequence.Action.Vehicle.SequenceActionVehicleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reqSwitchCamera_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cameraSwitched_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin end_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reqCamera_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionEnterVehicle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionEnterVehicle", 0, Black.Sequence.Action.Vehicle.SequenceActionEnterVehicle.ObjectType, null, properties, 0, 2368);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionEnterVehicle", base.GetFieldProperties(), 1136987764, 1875262605);
            return fieldProperties;
        }

		
    }
}