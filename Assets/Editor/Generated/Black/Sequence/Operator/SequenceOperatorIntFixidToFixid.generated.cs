using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Operator
{
    public partial class SequenceOperatorIntFixidToFixid : Black.Sequence.Operator.SequenceOperatorCalculateBase
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

            var dummy = new SequenceOperatorIntFixidToFixid();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Operator.SequenceOperatorIntFixidToFixid", 0, Black.Sequence.Operator.SequenceOperatorIntFixidToFixid.ObjectType, null, properties, 0, 312);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Operator.SequenceOperatorIntFixidToFixid", base.GetFieldProperties(), 1861914757, -77064345);
            return fieldProperties;
        }

		
    }
}