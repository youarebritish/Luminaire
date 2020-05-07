using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Buddy
{
    public partial class SequenceActionAIBuddyDriveEventWait : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin cancelPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin tryWaitPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin timeOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin successPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failurePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cancelOutPin_;
		public bool bTryWait_;
		public float waitTimeout_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIBuddyDriveEventWait();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyDriveEventWait", 0, Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyDriveEventWait.ObjectType, null, properties, 0, 848);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyDriveEventWait", base.GetFieldProperties(), 241359551, -1619956266);
            return fieldProperties;
        }

		
    }
}