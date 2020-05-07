using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control
{
    public partial class SequenceActionControlRandom : Black.Sequence.Control.SequenceActionControlFallBackable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fixidIndexPinNoin_;
		public int argumentNum_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin8_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin7_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin6_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin5_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin4_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin3_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicTriggerOutputPin1_;
		public int randomPer1;
		public int randomPer2;
		public int randomPer3;
		public int randomPer4;
		public int randomPer5;
		public int randomPer6;
		public int randomPer7;
		public int randomPer8;
		public bool isReset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionControlRandom();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.SequenceActionControlRandom", 0, Black.Sequence.Control.SequenceActionControlRandom.ObjectType, null, properties, 0, 1208);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.SequenceActionControlRandom", base.GetFieldProperties(), -1580435457, -1664490678);
            return fieldProperties;
        }

		
    }
}