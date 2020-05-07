using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer.WorldShareCreate
{
    public partial class SequenceMultiPlayerSyncFixidValue : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inStartSync_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outSynced_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outFailure_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inFixidValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inArgValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outSyncedFixid_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outSyncedArg_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outSyncingList_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outFailureList_;
		public uint uniqueFilterId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiPlayerSyncFixidValue();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.WorldShareCreate.SequenceMultiPlayerSyncFixidValue", 0, Black.Sequence.MultiPlayer.WorldShareCreate.SequenceMultiPlayerSyncFixidValue.ObjectType, null, properties, 0, 1136);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.WorldShareCreate.SequenceMultiPlayerSyncFixidValue", base.GetFieldProperties(), 555831877, 695123296);
            
			
			
			return fieldProperties;
        }

		
    }
}