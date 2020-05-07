using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionOpenQuestSelect : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin questEntryId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin closed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin main_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin betsu_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outSelectedQuestId_;
		public bool isSelectFromList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionOpenQuestSelect();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionOpenQuestSelect", 0, Black.Sequence.Action.Menu.SequenceActionOpenQuestSelect.ObjectType, null, properties, 0, 904);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionOpenQuestSelect", base.GetFieldProperties(), 1501255287, 154443642);
            return fieldProperties;
        }

		
    }
}