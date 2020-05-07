using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableLabeled : Black.Sequence.Variable.SequenceVariableLabeledStringBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int labelType_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin dynamicVarOutputPin4_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin dynamicVarOutputPin3_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin dynamicVarOutputPin2_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin get_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin set_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableLabeled();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableLabeled", 0, Black.Sequence.Variable.SequenceVariableLabeled.ObjectType, null, properties, 0, 872);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableLabeled", base.GetFieldProperties(), 1729575923, -31387927);
            return fieldProperties;
        }

		
    }
}