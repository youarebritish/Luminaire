using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Body
{
    public partial class SequenceActionActorBodyRequestDeathMessage : Black.Sequence.Action.Actor.Body.SequenceActionActorBodyRequestMessage
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actionDeathTypePin_;
		public bool checkDeath_;
		public uint checkTag_;
		public uint bodyConditionMessageId;
		public uint animConditionBBParamId;
		public int actionConditionType;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorBodyRequestDeathMessage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Body.SequenceActionActorBodyRequestDeathMessage", 0, Black.Sequence.Action.Actor.Body.SequenceActionActorBodyRequestDeathMessage.ObjectType, null, properties, 0, 1168);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Body.SequenceActionActorBodyRequestDeathMessage", base.GetFieldProperties(), 530929551, 1608471650);
            
			
			
			return fieldProperties;
        }

		
    }
}