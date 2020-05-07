using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Buddy
{
    public partial class SequenceActionAIBuddySetReaction : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin endPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin startOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin endOutPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin autoFinishPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin startedPin_;
		public int motionType_;
		public int finishBuddyType_;
		public bool dontPlayWhenEventWait_;
		public bool isEnableAutoResetBySpeed_;
		public bool isSyncPlay_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIBuddySetReaction();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddySetReaction", 0, Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddySetReaction.ObjectType, null, properties, 0, 864);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddySetReaction", base.GetFieldProperties(), -1205231986, -151468374);
            return fieldProperties;
        }

		
    }
}