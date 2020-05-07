using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Operator
{
    public partial class SequenceOperatorScreenPositionAlign : Black.Sequence.Operator.SequenceOperatorCalculateBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputValuePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputValue_;
		public int align_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceOperatorScreenPositionAlign();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Operator.SequenceOperatorScreenPositionAlign", 0, Black.Sequence.Operator.SequenceOperatorScreenPositionAlign.ObjectType, null, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Operator.SequenceOperatorScreenPositionAlign", base.GetFieldProperties(), 980604949, 449822137);
            return fieldProperties;
        }

		
    }
}