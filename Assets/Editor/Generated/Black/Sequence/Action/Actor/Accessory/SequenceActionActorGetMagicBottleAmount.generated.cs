using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Accessory
{
    public partial class SequenceActionActorGetMagicBottleAmount : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int magicBottleType_;
		public uint magicBottleId_;
		public int checkMagicBottle_;
		public bool checkIdOnly_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin int_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin exist_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin notExist_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorGetMagicBottleAmount();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Accessory.SequenceActionActorGetMagicBottleAmount", 0, Black.Sequence.Action.Actor.Accessory.SequenceActionActorGetMagicBottleAmount.ObjectType, null, properties, 0, 672);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Accessory.SequenceActionActorGetMagicBottleAmount", base.GetFieldProperties(), -1631498275, 1873184788);
            return fieldProperties;
        }

		
    }
}