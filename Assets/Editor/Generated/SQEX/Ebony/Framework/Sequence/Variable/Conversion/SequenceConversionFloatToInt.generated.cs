using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable.Conversion
{
    public partial class SequenceConversionFloatToInt : SQEX.Ebony.Framework.Sequence.Operator.SequenceOperator
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin v_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin o_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConversionFloatToInt();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.Conversion.SequenceConversionFloatToInt", 0, SQEX.Ebony.Framework.Sequence.Variable.Conversion.SequenceConversionFloatToInt.ObjectType, null, properties, 0, 264);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.Conversion.SequenceConversionFloatToInt", base.GetFieldProperties(), 786708762, 2028809915);
            return fieldProperties;
        }

		
    }
}