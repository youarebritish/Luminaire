using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable
{
    public partial class SequenceOperatorCompare : SQEX.Ebony.Framework.Sequence.Operator.SequenceOperator
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin in2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin in1_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin out_;
		public int operator_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceOperatorCompare();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.SequenceOperatorCompare", 0, SQEX.Ebony.Framework.Sequence.Variable.SequenceOperatorCompare.ObjectType, null, properties, 0, 360);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.SequenceOperatorCompare", base.GetFieldProperties(), 1126815866, 1530668142);
            
			
			
			return fieldProperties;
        }

		
    }
}