using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimedQuest
{
    public partial class SequenceActionTimedQuestGetPoint : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin scheduleId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mainPoint_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin limitPoint_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimedQuestGetPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimedQuest.SequenceActionTimedQuestGetPoint", 0, Black.Sequence.Action.TimedQuest.SequenceActionTimedQuestGetPoint.ObjectType, null, properties, 0, 632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimedQuest.SequenceActionTimedQuestGetPoint", base.GetFieldProperties(), 1756802090, 2036690286);
            return fieldProperties;
        }

		
    }
}