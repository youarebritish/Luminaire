using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Buddy
{
    public partial class SequenceActionAIBuddyGetRole : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin noctisPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin gladiolusPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin ignisPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin promptoPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin nonePin_;
		public int job_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIBuddyGetRole();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyGetRole", 0, Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyGetRole.ObjectType, null, properties, 0, 768);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyGetRole", base.GetFieldProperties(), 802969512, 618829665);
            return fieldProperties;
        }

		
    }
}