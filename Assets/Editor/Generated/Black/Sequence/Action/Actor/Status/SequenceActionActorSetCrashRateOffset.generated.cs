using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Status
{
    public partial class SequenceActionActorSetCrashRateOffset : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int crashRateOffset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorSetCrashRateOffset();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Status.SequenceActionActorSetCrashRateOffset", 0, Black.Sequence.Action.Actor.Status.SequenceActionActorSetCrashRateOffset.ObjectType, null, properties, 0, 376);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Status.SequenceActionActorSetCrashRateOffset", base.GetFieldProperties(), -1606501676, 1318592017);
            return fieldProperties;
        }

		
    }
}