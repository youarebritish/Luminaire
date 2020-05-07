using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorPlayBodyLinkAnimStatus : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint roleId;
		public int status;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorPlayBodyLinkAnimStatus();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorPlayBodyLinkAnimStatus", 0, Black.Sequence.Action.Actor.SequenceActionActorPlayBodyLinkAnimStatus.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorPlayBodyLinkAnimStatus", base.GetFieldProperties(), -536337515, -567630761);
            return fieldProperties;
        }

		
    }
}