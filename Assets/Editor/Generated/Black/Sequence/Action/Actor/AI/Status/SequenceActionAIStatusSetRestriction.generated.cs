using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.Status
{
    public partial class SequenceActionAIStatusSetRestriction : Black.Sequence.Action.Actor.AI.Status.SequenceActionAIStatusSetEnableBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int restrictionType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIStatusSetRestriction();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.Status.SequenceActionAIStatusSetRestriction", 0, Black.Sequence.Action.Actor.AI.Status.SequenceActionAIStatusSetRestriction.ObjectType, null, properties, 0, 776);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.Status.SequenceActionAIStatusSetRestriction", base.GetFieldProperties(), 682448260, 1393645482);
            return fieldProperties;
        }

		
    }
}