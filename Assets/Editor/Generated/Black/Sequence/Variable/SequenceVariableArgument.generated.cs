using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableArgument : Black.Sequence.Variable.SequenceVariableLabeledStringBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int labelType_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin dynamicVarOutputPin4_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin dynamicVarOutputPin3_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin dynamicVarOutputPin2_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin get_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableArgument();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableArgument", 0, Black.Sequence.Variable.SequenceVariableArgument.ObjectType, null, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableArgument", base.GetFieldProperties(), -402115190, -381999755);
            
			
			
			return fieldProperties;
        }

		
    }
}