using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable
{
    public partial class SequenceOperatorNot : SQEX.Ebony.Framework.Sequence.Operator.SequenceOperator
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin out_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceOperatorNot();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.SequenceOperatorNot", 0, SQEX.Ebony.Framework.Sequence.Variable.SequenceOperatorNot.ObjectType, null, properties, 0, 264);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.SequenceOperatorNot", base.GetFieldProperties(), 2025011684, -476892725);
            return fieldProperties;
        }

		
    }
}