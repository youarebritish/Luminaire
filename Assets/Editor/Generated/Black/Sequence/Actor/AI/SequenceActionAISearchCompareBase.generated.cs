using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI
{
    public partial class SequenceActionAISearchCompareBase : Black.Sequence.Actor.AI.SequenceActionAISearchBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin immutable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin change_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failure_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAISearchCompareBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.SequenceActionAISearchCompareBase", 0, Black.Sequence.Actor.AI.SequenceActionAISearchCompareBase.ObjectType, null, properties, 0, 848);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.SequenceActionAISearchCompareBase", base.GetFieldProperties(), 106046069, 1057957585);
            return fieldProperties;
        }

		
    }
}