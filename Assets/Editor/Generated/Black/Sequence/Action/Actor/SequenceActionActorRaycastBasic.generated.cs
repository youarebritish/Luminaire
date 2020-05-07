using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorRaycastBasic : Black.Sequence.Action.Base.SequenceActionRaycastBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isHitCharacter_;
		public bool isHitMap_;
		public bool isHitRigidBody_;
		public bool isDebugDraw_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorRaycastBasic();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorRaycastBasic", 0, Black.Sequence.Action.Actor.SequenceActionActorRaycastBasic.ObjectType, null, properties, 0, 1024);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorRaycastBasic", base.GetFieldProperties(), 652333429, 1735104126);
            return fieldProperties;
        }

		
    }
}