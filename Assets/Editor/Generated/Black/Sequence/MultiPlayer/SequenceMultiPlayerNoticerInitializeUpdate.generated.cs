using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiPlayerNoticerInitializeUpdate : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inActivate_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inInitializeSync_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inInitializedFinished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inInitializedSyncFailed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inIsSyncNumber_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inSyncId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inIsOwner_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outWaitInitializedStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outSendRequestAndQuestProgress_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outSetQuestProgress_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outCurrentInitId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerNoticerInitializeUpdate();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiPlayerNoticerInitializeUpdate", 0, Black.Sequence.MultiPlayer.SequenceMultiPlayerNoticerInitializeUpdate.ObjectType, null, properties, 0, 1208);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiPlayerNoticerInitializeUpdate", base.GetFieldProperties(), 370306430, -570536771);
            
			
			
			return fieldProperties;
        }

		
    }
}