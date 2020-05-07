using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Accessory
{
    public partial class SequenceActionActorChangeJacket : Black.Sequence.Actor.SequenceActionActorStatusOneBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin bool_;
		public int playerBankNumber_;
		public bool JacketOn_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorChangeJacket();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Accessory.SequenceActionActorChangeJacket", 0, Black.Sequence.Action.Actor.Accessory.SequenceActionActorChangeJacket.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Accessory.SequenceActionActorChangeJacket", base.GetFieldProperties(), 389378054, -1259238052);
            return fieldProperties;
        }

		
    }
}