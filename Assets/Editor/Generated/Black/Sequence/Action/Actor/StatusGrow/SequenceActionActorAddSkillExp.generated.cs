using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.StatusGrow
{
    public partial class SequenceActionActorAddSkillExp : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int playerBankNumber_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin addSkillExpPin_;
		public int addSkillExp_;
		public bool drawMenu_;
		public bool randomPlayer_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin menu_finish_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorAddSkillExp();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.StatusGrow.SequenceActionActorAddSkillExp", 0, Black.Sequence.Action.Actor.StatusGrow.SequenceActionActorAddSkillExp.ObjectType, null, properties, 0, 680);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.StatusGrow.SequenceActionActorAddSkillExp", base.GetFieldProperties(), 1425284304, -1885380526);
            return fieldProperties;
        }

		
    }
}