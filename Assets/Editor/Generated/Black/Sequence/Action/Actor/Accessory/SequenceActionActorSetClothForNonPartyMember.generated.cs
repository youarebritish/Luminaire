using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Accessory
{
    public partial class SequenceActionActorSetClothForNonPartyMember : Black.Sequence.Actor.SequenceActionActorStatusOneBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failedPin_;
		public int playerBankNumber_;
		public uint clothId_;
		public bool injured_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorSetClothForNonPartyMember();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Accessory.SequenceActionActorSetClothForNonPartyMember", 0, Black.Sequence.Action.Actor.Accessory.SequenceActionActorSetClothForNonPartyMember.ObjectType, null, properties, 0, 672);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Accessory.SequenceActionActorSetClothForNonPartyMember", base.GetFieldProperties(), 49525356, -2061406535);
            return fieldProperties;
        }

		
    }
}