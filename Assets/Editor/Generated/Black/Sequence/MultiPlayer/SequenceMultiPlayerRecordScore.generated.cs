using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerRecordScore : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueTime_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueQuestID_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueScore_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueTotal_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueDaily_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueHourly_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFinished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outExpired_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outNotElapsedTime_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFailed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outMaintenance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerRecordScore();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerRecordScore", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerRecordScore.ObjectType, null, properties, 0, 1376);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerRecordScore", base.GetFieldProperties(), -1992829453, -1426485555);
            
			
			
			return fieldProperties;
        }

		
    }
}