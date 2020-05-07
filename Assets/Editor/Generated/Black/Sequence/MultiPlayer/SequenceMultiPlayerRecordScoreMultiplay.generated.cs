using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerRecordScoreMultiplay : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFinished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFailed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outMaintenance_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outNotElapsedTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerRecordScoreMultiplay();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerRecordScoreMultiplay", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerRecordScoreMultiplay.ObjectType, null, properties, 0, 7656);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerRecordScoreMultiplay", base.GetFieldProperties(), 1117296243, -1771588089);
            return fieldProperties;
        }

		
    }
}