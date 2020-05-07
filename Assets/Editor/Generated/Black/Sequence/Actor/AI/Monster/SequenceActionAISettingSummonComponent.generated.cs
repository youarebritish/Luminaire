using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Monster
{
    public partial class SequenceActionAISettingSummonComponent : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public float minDistanceFromSummoner_;
		public float maxDistanceFromSummoner_;
		public float minDistanceBetweenSummonedActor_;
		public string charaEntryPath0_;
		public int maxNum0_;
		public string charaEntryPath1_;
		public int maxNum1_;
		public string charaEntryPath2_;
		public int maxNum2_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAISettingSummonComponent();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Monster.SequenceActionAISettingSummonComponent", 0, Black.Sequence.Actor.AI.Monster.SequenceActionAISettingSummonComponent.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Monster.SequenceActionAISettingSummonComponent", base.GetFieldProperties(), 201588686, 252105503);
            
			
			
			return fieldProperties;
        }

		
    }
}