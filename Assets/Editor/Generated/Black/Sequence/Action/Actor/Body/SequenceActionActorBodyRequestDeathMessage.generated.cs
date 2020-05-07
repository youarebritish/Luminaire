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
            
			fieldProperties.AddProperty(new Property("actionDeathTypePin_", 1305961911, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1056, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkDeath_", 1977343996, "bool", 1144, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkTag_", 3192159798, "SQEX.Ebony.Std.Fixid", 1148, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("bodyConditionMessageId", 3825275832, "SQEX.Ebony.Std.Fixid", 1152, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("animConditionBBParamId", 2532878623, "SQEX.Ebony.Std.Fixid", 1156, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("actionConditionType", 755918976, "int", 1160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}