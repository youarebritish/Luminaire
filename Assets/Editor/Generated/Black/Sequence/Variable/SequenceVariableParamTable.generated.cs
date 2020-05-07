using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableParamTable : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint tableId_;
		public uint tagId_;
		public uint tagIdNoPrefix_;
		public uint elementId_;
		public uint elementIdNoPrefix_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin variableElementId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin variableTagId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin variableTableId_;
		public IList<SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveBase> arguments_;
		public bool specifyTable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableParamTable();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableParamTable", 0, Black.Sequence.Variable.SequenceVariableParamTable.ObjectType, null, properties, 0, 400);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableParamTable", base.GetFieldProperties(), -1385974330, -1815547541);
            return fieldProperties;
        }

		
    }
}