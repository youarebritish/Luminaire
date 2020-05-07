using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable.Conversion
{
    public partial class SequenceConversionFloatToVector : SQEX.Ebony.Framework.Sequence.Operator.SequenceOperator
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin x_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin y_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin z_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin w_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin out_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConversionFloatToVector();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.Conversion.SequenceConversionFloatToVector", 0, SQEX.Ebony.Framework.Sequence.Variable.Conversion.SequenceConversionFloatToVector.ObjectType, null, properties, 0, 528);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.Conversion.SequenceConversionFloatToVector", base.GetFieldProperties(), 1839387883, -971197813);
            
			
			
			return fieldProperties;
        }

		
    }
}