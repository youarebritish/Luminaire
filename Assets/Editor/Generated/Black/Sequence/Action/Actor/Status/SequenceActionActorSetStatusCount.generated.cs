using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Status
{
    public partial class SequenceActionActorSetStatusCount : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin release_;
		public int statusCount_;
		public int statusCountLevel_;
		public int statusCountTime_;
		public bool drawMenu_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin menu_finish_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorSetStatusCount();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Status.SequenceActionActorSetStatusCount", 0, Black.Sequence.Action.Actor.Status.SequenceActionActorSetStatusCount.ObjectType, null, properties, 0, 688);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Status.SequenceActionActorSetStatusCount", base.GetFieldProperties(), -1747161918, 1817061036);
            return fieldProperties;
        }

		
    }
}