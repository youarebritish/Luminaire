using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Minigame.Colosseum
{
    public partial class SequenceActionColosseumSetBetGroup : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groupIdPin_;
		public uint groupId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionColosseumSetBetGroup();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumSetBetGroup", 0, Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumSetBetGroup.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Minigame.Colosseum.SequenceActionColosseumSetBetGroup", base.GetFieldProperties(), 2138421075, -2134289922);
            return fieldProperties;
        }

		
    }
}