using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Control
{
    public partial class SequenceActionControlSwitchFixidParam : SQEX.Ebony.Framework.Sequence.Control.SequenceControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin value_;
		public int argumentNum_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin8_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin7_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin6_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin5_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin4_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin3_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputDefaultPin_;
		public uint fixid1_;
		public uint fixid2_;
		public uint fixid3_;
		public uint fixid4_;
		public uint fixid5_;
		public uint fixid6_;
		public uint fixid7_;
		public uint fixid8_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionControlSwitchFixidParam();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Control.SequenceActionControlSwitchFixidParam", 0, Black.Sequence.Action.Control.SequenceActionControlSwitchFixidParam.ObjectType, null, properties, 0, 1296);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Control.SequenceActionControlSwitchFixidParam", base.GetFieldProperties(), -1680758712, -4791471);
            return fieldProperties;
        }

		
    }
}