using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Physics
{
    public partial class SequenceActionActorBonamikCollision : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin removePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin colliderPin_;
		public int actorGroup0;
		public int actorGroup1;
		public int actorGroup2;
		public int actorGroup3;
		public int actorGroup4;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorBonamikCollision();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikCollision", 0, Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikCollision.ObjectType, null, properties, 0, 576);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikCollision", base.GetFieldProperties(), 1852728982, 1265434576);
            
			fieldProperties.AddProperty(new Property("inputPin_", 724407991, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("removePin_", 2971453305, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorPin_", 3381458010, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 376, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("colliderPin_", 3391258553, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorGroup0", 593034375, "Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikCollision.eCOLLIDERGROUP", 552, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorGroup1", 576256756, "Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikCollision.eCOLLIDERGROUP", 556, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorGroup2", 626589613, "Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikCollision.eCOLLIDERGROUP", 560, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorGroup3", 609811994, "Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikCollision.eCOLLIDERGROUP", 564, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorGroup4", 525923899, "Black.Sequence.Action.Actor.Physics.SequenceActionActorBonamikCollision.eCOLLIDERGROUP", 568, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}