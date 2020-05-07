using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Vehicle
{
    public partial class SequenceActionAIVehicleSetAssist : Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inVehicleActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin floatPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin floatKeepTimePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin floatKeepSpeedPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin boolPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin integerPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin stopped_;
		public int target_;
		public float floatValue_;
		public float floatKeepTimeValue_;
		public float floatKeepSpeedValue_;
		public IList<Black.Sequence.Actor.AI.Vehicle.VehicleNavigationDestIdItem> destList_;
		public bool isLoopValue_;
		public int loopNumValue_;
		public bool isStopEngineAtEnd_;
		public bool boolValue_;
		public int getOffType_;
		public bool isNeedChangeVehicleCamera_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIVehicleSetAssist();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleSetAssist", 0, Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleSetAssist.ObjectType, null, properties, 0, 1168);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleSetAssist", base.GetFieldProperties(), 773530251, 608122716);
            return fieldProperties;
        }

		
    }
}