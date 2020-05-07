using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Minigame.Fishing
{
    public partial class SequenceActionFishingCheckFishTag : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin none_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin tagged_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionFishingCheckFishTag();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Minigame.Fishing.SequenceActionFishingCheckFishTag", 0, Black.Sequence.Action.Minigame.Fishing.SequenceActionFishingCheckFishTag.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Minigame.Fishing.SequenceActionFishingCheckFishTag", base.GetFieldProperties(), -1721060198, -752899656);
            
			
			
			return fieldProperties;
        }

		
    }
}