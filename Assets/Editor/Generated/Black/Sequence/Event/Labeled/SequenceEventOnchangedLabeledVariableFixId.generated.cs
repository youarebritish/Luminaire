using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Labeled
{
    public partial class SequenceEventOnchangedLabeledVariableFixId : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reRegister_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin wakeUp_;
		public int prefixType_;
		public uint labeledVarId_;
		public uint globalLabelId_;
		public int labelScope_;
		public IList<SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareCollectionBase> conditions_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventOnchangedLabeledVariableFixId();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Labeled.SequenceEventOnchangedLabeledVariableFixId", 0, Black.Sequence.Event.Labeled.SequenceEventOnchangedLabeledVariableFixId.ObjectType, null, properties, 0, 544);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Labeled.SequenceEventOnchangedLabeledVariableFixId", base.GetFieldProperties(), 584263652, -248131269);
            
			fieldProperties.AddProperty(new Property("reRegister_", 1075713906, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 248, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("wakeUp_", 1545670293, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 344, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("prefixType_", 3044571194, "Black.Sequence.Event.Labeled.SequenceEventOnchangedLabeledVariableFixId.PREFIX_TYPE", 440, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("labeledVarId_", 2608703597, "SQEX.Ebony.Std.Fixid", 444, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("globalLabelId_", 65495522, "SQEX.Ebony.Std.Fixid", 448, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelScope_", 12303572, "Black.System.Labeled.LabeledVariableManager.LabeledScope", 452, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("conditions_", 3387481400, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareCollectionBase* >", 456, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}