using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Operator
{
    public partial class SequenceOperatorCalculateInt : Black.Sequence.Operator.SequenceOperatorCalculateBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int operatorType_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dynamicVarInputPin1_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin setPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin dynamicVarOutputPin1_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceOperatorCalculateInt();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Operator.SequenceOperatorCalculateInt", 0, Black.Sequence.Operator.SequenceOperatorCalculateInt.ObjectType, null, properties, 0, 584);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Operator.SequenceOperatorCalculateInt", base.GetFieldProperties(), 1639833133, -1189611088);
            return fieldProperties;
        }

		
    }
}