using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorRaycastPosition : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outHit_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outNoHit_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outValueHitPosition_;
		public float rayDistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorRaycastPosition();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorRaycastPosition", 0, Black.Sequence.Action.Actor.SequenceActionActorRaycastPosition.ObjectType, null, properties, 0, 688);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorRaycastPosition", base.GetFieldProperties(), 275022870, -160855532);
            
			
			
			return fieldProperties;
        }

		
    }
}