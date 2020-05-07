using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Minigame.Colosseum
{
    public partial class SequenceActionColosseumSupportCondition : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin successPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin failurePin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionColosseumSupportCondition();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumSupportCondition", 0, Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumSupportCondition.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumSupportCondition", base.GetFieldProperties(), -1880986762, -2046717986);
            return fieldProperties;
        }

		
    }
}