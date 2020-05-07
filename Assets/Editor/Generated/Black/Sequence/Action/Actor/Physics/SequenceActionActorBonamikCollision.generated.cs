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
            return fieldProperties;
        }

		
    }
}