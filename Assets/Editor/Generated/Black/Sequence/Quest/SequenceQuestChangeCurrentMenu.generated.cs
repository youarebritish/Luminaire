using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Quest
{
    public partial class SequenceQuestChangeCurrentMenu : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin questIdPin_;
		public uint questId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceQuestChangeCurrentMenu();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Quest.SequenceQuestChangeCurrentMenu", 0, Black.Sequence.Quest.SequenceQuestChangeCurrentMenu.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Quest.SequenceQuestChangeCurrentMenu", base.GetFieldProperties(), -1135217505, 332396168);
            return fieldProperties;
        }

		
    }
}