using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.StatusGrow
{
    public partial class SequenceActionActorAddLevel : Black.Sequence.Actor.SequenceActionActorStatusOneBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int playerBankNumber_;
		public int level_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin level_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorAddLevel();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.StatusGrow.SequenceActionActorAddLevel", 0, Black.Sequence.Action.Actor.StatusGrow.SequenceActionActorAddLevel.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.StatusGrow.SequenceActionActorAddLevel", base.GetFieldProperties(), -1365738623, 1781670682);
            return fieldProperties;
        }

		
    }
}