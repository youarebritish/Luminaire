using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer.WorldShareCreate
{
    public partial class SequenceMultiPlayerSetAndGetWorldCreateLocalVariable : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inAdd_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inClear_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inRemove_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inFixidValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inRemoveIndex_;
		public int variableName_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outListValue_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerSetAndGetWorldCreateLocalVariable();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.WorldShareCreate.SequenceMultiPlayerSetAndGetWorldCreateLocalVariable", 0, Black.Sequence.MultiPlayer.WorldShareCreate.SequenceMultiPlayerSetAndGetWorldCreateLocalVariable.ObjectType, null, properties, 0, 832);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.WorldShareCreate.SequenceMultiPlayerSetAndGetWorldCreateLocalVariable", base.GetFieldProperties(), 1390886970, 989582302);
            
			fieldProperties.AddProperty(new Property("inAdd_", 552830470, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inClear_", 3302757968, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inRemove_", 1841991775, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inFixidValue_", 2161307878, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 560, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("inRemoveIndex_", 867682339, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 648, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("variableName_", 404460635, "Black.Sequence.MultiPlayer.WorldShareCreate.SequenceMultiPlayerSetAndGetWorldCreateLocalVariable.SetVariableName", 736, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("outListValue_", 3770292697, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}