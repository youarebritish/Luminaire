using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Operator
{
    public partial class SequenceOperatorSwitchValueIntToFixid : Black.Sequence.Operator.SequenceOperatorCalculateBase
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
		public int condition12_;
		public int condition13_;
		public uint resultValue1_;
		public uint resultValue2_;
		public uint resultValue3_;
		public uint resultValue4_;
		public uint resultValue5_;
		public uint resultValue6_;
		public uint resultValue7_;
		public uint resultValue8_;
		public uint resultValue9_;
		public uint resultValue10_;
		public uint resultValue11_;
		public uint resultValue12_;
		public uint resultValue13_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceOperatorSwitchValueIntToFixid();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Operator.SequenceOperatorSwitchValueIntToFixid", 0, Black.Sequence.Operator.SequenceOperatorSwitchValueIntToFixid.ObjectType, null, properties, 0, 416);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Operator.SequenceOperatorSwitchValueIntToFixid", base.GetFieldProperties(), -1590707014, -252086618);
            
			
			
			return fieldProperties;
        }

		
    }
}