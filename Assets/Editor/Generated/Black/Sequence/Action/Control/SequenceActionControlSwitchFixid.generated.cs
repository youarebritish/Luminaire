using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Control
{
    public partial class SequenceActionControlSwitchFixid : SQEX.Ebony.Framework.Sequence.Control.SequenceControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin value_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin3_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin4_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin5_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin6_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin7_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin8_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputDefaultPin_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData fixid1_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData fixid2_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData fixid3_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData fixid4_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData fixid5_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData fixid6_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData fixid7_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData fixid8_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionControlSwitchFixid();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Control.SequenceActionControlSwitchFixid", 0, Black.Sequence.Action.Control.SequenceActionControlSwitchFixid.ObjectType, null, properties, 0, 1392);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Control.SequenceActionControlSwitchFixid", base.GetFieldProperties(), -343651378, -617229844);
            return fieldProperties;
        }

		
    }
}