using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceConstantDinerEventTable : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dinerEventTableIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin animMsgIdIgnisPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin animMsgIdPin_;
		public uint dinerEventTableId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConstantDinerEventTable();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceConstantDinerEventTable", 0, Black.Sequence.Variable.SequenceConstantDinerEventTable.ObjectType, null, properties, 0, 360);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceConstantDinerEventTable", base.GetFieldProperties(), 2091444737, -1971236772);
            
			
			
			return fieldProperties;
        }

		
    }
}