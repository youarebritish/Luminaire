using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.StatusGrow
{
    public partial class SequenceActionActorGetSkillLevel : Black.Sequence.Actor.SequenceActionActorStatusOneBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int playerBankNumber_;
		public int checkSkillLevel_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin int_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin exist_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin notExist_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorGetSkillLevel();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.StatusGrow.SequenceActionActorGetSkillLevel", 0, Black.Sequence.Action.Actor.StatusGrow.SequenceActionActorGetSkillLevel.ObjectType, null, properties, 0, 760);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.StatusGrow.SequenceActionActorGetSkillLevel", base.GetFieldProperties(), 2031146755, -2037427679);
            return fieldProperties;
        }

		
    }
}