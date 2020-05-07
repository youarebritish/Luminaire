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
            
			
			
			return fieldProperties;
        }

		
    }
}