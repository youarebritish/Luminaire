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
            
			fieldProperties.AddProperty(new Property("tableId_", 214502039, "SQEX.Ebony.Std.Fixid", 88, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("tagId_", 4073554419, "SQEX.Ebony.Std.Fixid", 92, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("tagIdNoPrefix_", 1511036170, "SQEX.Ebony.Std.Fixid", 96, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("elementId_", 1896981983, "SQEX.Ebony.Std.Fixid", 100, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("elementIdNoPrefix_", 2818406342, "SQEX.Ebony.Std.Fixid", 104, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("variableElementId_", 3830839871, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 112, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("variableTagId_", 2970143059, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 200, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("variableTableId_", 886245367, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 288, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("arguments_", 3418293824, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveBase* >", 376, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("specifyTable_", 3498201009, "bool", 392, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}