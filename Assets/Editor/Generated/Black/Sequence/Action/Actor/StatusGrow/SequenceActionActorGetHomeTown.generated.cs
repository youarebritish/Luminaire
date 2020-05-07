using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.StatusGrow
{
    public partial class SequenceActionActorGetHomeTown : Black.Sequence.Actor.SequenceActionActorStatusOneBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int playerBankNumber_;
		public uint home_town_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin home_town_pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin equal_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin notEqual_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorGetHomeTown();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.StatusGrow.SequenceActionActorGetHomeTown", 0, Black.Sequence.Action.Actor.StatusGrow.SequenceActionActorGetHomeTown.ObjectType, null, properties, 0, 752);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.StatusGrow.SequenceActionActorGetHomeTown", base.GetFieldProperties(), 2124458379, 2107136715);
            return fieldProperties;
        }

		
    }
}