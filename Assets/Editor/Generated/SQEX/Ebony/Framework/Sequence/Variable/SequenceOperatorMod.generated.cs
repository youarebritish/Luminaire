using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable
{
    public partial class SequenceOperatorMod : SQEX.Ebony.Framework.Sequence.Operator.SequenceOperator
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin in1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin in2_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin out_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceOperatorMod();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.SequenceOperatorMod", 0, SQEX.Ebony.Framework.Sequence.Variable.SequenceOperatorMod.ObjectType, null, properties, 0, 352);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.SequenceOperatorMod", base.GetFieldProperties(), 69745124, 555990539);
            return fieldProperties;
        }

		
    }
}