using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control
{
    public partial class SequenceActionControlLabeledFunction : Black.Sequence.Control.SequenceActionControlLabeled
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int argumentNum_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin dynamicVarOutputPin8_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin dynamicVarOutputPin7_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin dynamicVarOutputPin6_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin dynamicVarOutputPin5_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin dynamicVarOutputPin4_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin dynamicVarOutputPin3_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin dynamicVarOutputPin2_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin dynamicVarOutputPin1_;
		public bool bZeroFrameFunc_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionControlLabeledFunction();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.SequenceActionControlLabeledFunction", 0, Black.Sequence.Control.SequenceActionControlLabeledFunction.ObjectType, null, properties, 0, 1136);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.SequenceActionControlLabeledFunction", base.GetFieldProperties(), -154381823, -1589797325);
            
			
			
			return fieldProperties;
        }

		
    }
}