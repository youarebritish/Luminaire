using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Actor
{
    public partial class SequenceEventActorBase : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventActorBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Actor.SequenceEventActorBase", 0, Black.Sequence.Event.Actor.SequenceEventActorBase.ObjectType, null, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Actor.SequenceEventActorBase", base.GetFieldProperties(), 685535186, -1434850584);
            return fieldProperties;
        }

		
    }
}