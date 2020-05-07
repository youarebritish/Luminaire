using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerPushStats : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueQuestId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueQuestResult_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueMatching_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValuePartyNum_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFinished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFailed_;
		public int questNum_;
		public bool questResult_;
		public int matching_;
		public int partyNum_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerPushStats();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerPushStats", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerPushStats.ObjectType, null, properties, 0, 928);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerPushStats", base.GetFieldProperties(), -521871909, -1375164834);
            
			
			
			return fieldProperties;
        }

		
    }
}