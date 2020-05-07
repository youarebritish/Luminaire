using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceConstantDinerData : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dinerIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin firstTimeIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin eventTableIdPin_;
		public uint dinerId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConstantDinerData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceConstantDinerData", 0, Black.Sequence.Variable.SequenceConstantDinerData.ObjectType, null, properties, 0, 360);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceConstantDinerData", base.GetFieldProperties(), -1635310714, 1975433424);
            
			
			
			return fieldProperties;
        }

		
    }
}