using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable.Conversion
{
    public partial class SequenceConversionVectorToFloat : SQEX.Ebony.Framework.Sequence.Operator.SequenceOperator
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin v_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin x_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin y_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin z_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin w_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConversionVectorToFloat();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.Conversion.SequenceConversionVectorToFloat", 0, SQEX.Ebony.Framework.Sequence.Variable.Conversion.SequenceConversionVectorToFloat.ObjectType, null, properties, 0, 528);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.Conversion.SequenceConversionVectorToFloat", base.GetFieldProperties(), -1992500897, -1199137918);
            return fieldProperties;
        }

		
    }
}