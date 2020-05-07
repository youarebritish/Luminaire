using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.Interrupt
{
    public partial class SequenceActionAIRequestMessage : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public uint aiMessageId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIRequestMessage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.Interrupt.SequenceActionAIRequestMessage", 0, Black.Sequence.Action.Actor.AI.Interrupt.SequenceActionAIRequestMessage.ObjectType, null, properties, 0, 488);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.Interrupt.SequenceActionAIRequestMessage", base.GetFieldProperties(), -414482573, -881090026);
            return fieldProperties;
        }

		
    }
}