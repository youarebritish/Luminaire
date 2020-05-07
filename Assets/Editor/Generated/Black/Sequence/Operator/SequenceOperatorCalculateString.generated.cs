using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Operator
{
    public partial class SequenceOperatorCalculateString : Black.Sequence.Operator.SequenceOperatorCalculateBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int operatorType_;
		public int figureLength_;
		public bool isZeroFill_;
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

            var dummy = new SequenceOperatorCalculateString();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Operator.SequenceOperatorCalculateString", 0, Black.Sequence.Operator.SequenceOperatorCalculateString.ObjectType, null, properties, 0, 504);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Operator.SequenceOperatorCalculateString", base.GetFieldProperties(), 163034519, 822217972);
            return fieldProperties;
        }

		
    }
}