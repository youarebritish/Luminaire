using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.StatusGrow
{
    public partial class SequenceActionActorGetSkillNextExp : Black.Sequence.Actor.SequenceActionActorStatusOneBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int playerBankNumber_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin int_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorGetSkillNextExp();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.StatusGrow.SequenceActionActorGetSkillNextExp", 0, Black.Sequence.Action.Actor.StatusGrow.SequenceActionActorGetSkillNextExp.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.StatusGrow.SequenceActionActorGetSkillNextExp", base.GetFieldProperties(), 1363818926, -1597995059);
            return fieldProperties;
        }

		
    }
}