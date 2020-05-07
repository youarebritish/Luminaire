using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable.Conversion
{
    public partial class SequenceOperatorSwitchValueIntToString : SQEX.Ebony.Framework.Sequence.Operator.SequenceOperator
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputValuePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputValue_;
		public int condition1_;
		public int condition2_;
		public int condition3_;
		public int condition4_;
		public int condition5_;
		public int condition6_;
		public int condition7_;
		public int condition8_;
		public int condition9_;
		public int condition10_;
		public int condition11_;
		public string resultValue1_;
		public string resultValue2_;
		public string resultValue3_;
		public string resultValue4_;
		public string resultValue5_;
		public string resultValue6_;
		public string resultValue7_;
		public string resultValue8_;
		public string resultValue9_;
		public string resultValue10_;
		public string resultValue11_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceOperatorSwitchValueIntToString();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.Conversion.SequenceOperatorSwitchValueIntToString", 0, SQEX.Ebony.Framework.Sequence.Variable.Conversion.SequenceOperatorSwitchValueIntToString.ObjectType, null, properties, 0, 488);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.Conversion.SequenceOperatorSwitchValueIntToString", base.GetFieldProperties(), -1756623990, 68268498);
            
			
			
			return fieldProperties;
        }

		
    }
}