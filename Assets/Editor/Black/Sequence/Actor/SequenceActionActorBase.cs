using Ebony.Framework.Sequence;
using Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public class SequenceActionActorBase : SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorBase", 0, SequenceAction.ObjectType, Construct, properties, 1, 88);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorBase", base.GetFieldProperties(), -1818037369, -2072216373);
            return fieldProperties;
        }

        private static BaseObject Construct()
        {
            return new SequenceActionActorBase();
        }
    }
}
