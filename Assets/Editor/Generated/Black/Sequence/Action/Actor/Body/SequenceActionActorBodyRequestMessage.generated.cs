using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Body
{
    public partial class SequenceActionActorBodyRequestMessage : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin error_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actionTypePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin bodyMessageIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inTarget_;
		public uint bodyMessageId;
		public uint animBBParamId;
		public int actionType;
		public bool bDisableAI_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorBodyRequestMessage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Body.SequenceActionActorBodyRequestMessage", 0, Black.Sequence.Action.Actor.Body.SequenceActionActorBodyRequestMessage.ObjectType, null, properties, 0, 1056);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Body.SequenceActionActorBodyRequestMessage", base.GetFieldProperties(), -1365763752, -1668309380);
            
			
			
			return fieldProperties;
        }

		
    }
}