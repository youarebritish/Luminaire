using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Operator.Calculate
{
    public partial class SequenceOperatorIntegral : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin coefficient_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin start_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValuePin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceOperatorIntegral();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Operator.Calculate.SequenceOperatorIntegral", 0, Black.Sequence.Operator.Calculate.SequenceOperatorIntegral.ObjectType, null, properties, 0, 552);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Operator.Calculate.SequenceOperatorIntegral", base.GetFieldProperties(), -470741954, -544971899);
            return fieldProperties;
        }

		
    }
}