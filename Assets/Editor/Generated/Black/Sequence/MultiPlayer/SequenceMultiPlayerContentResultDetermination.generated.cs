using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerContentResultDetermination : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin successIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin failureIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin resetIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin successedOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failedOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin abortedOPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerContentResultDetermination();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerContentResultDetermination", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerContentResultDetermination.ObjectType, null, properties, 0, 848);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerContentResultDetermination", base.GetFieldProperties(), -1428137352, 92211914);
            return fieldProperties;
        }

		
    }
}