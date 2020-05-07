using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimedQuest
{
    public partial class SequenceActionTimedQuestGetTitle : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint titleIdProperty_;
		public bool drawMenu_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin titleId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ordinal_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rank_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin menu_finish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fail_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimedQuestGetTitle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimedQuest.SequenceActionTimedQuestGetTitle", 0, Black.Sequence.Action.TimedQuest.SequenceActionTimedQuestGetTitle.ObjectType, null, properties, 0, 928);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimedQuest.SequenceActionTimedQuestGetTitle", base.GetFieldProperties(), 271695840, 300168005);
            return fieldProperties;
        }

		
    }
}