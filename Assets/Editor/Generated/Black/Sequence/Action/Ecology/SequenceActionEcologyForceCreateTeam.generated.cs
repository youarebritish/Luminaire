using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Ecology
{
    public partial class SequenceActionEcologyForceCreateTeam : Black.Sequence.Action.Ecology.SequenceActionEcologyBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin Finished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin Failed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueTeamId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionEcologyForceCreateTeam();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Ecology.SequenceActionEcologyForceCreateTeam", 0, Black.Sequence.Action.Ecology.SequenceActionEcologyForceCreateTeam.ObjectType, null, properties, 0, 680);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Ecology.SequenceActionEcologyForceCreateTeam", base.GetFieldProperties(), 1862354950, 180274729);
            return fieldProperties;
        }

		
    }
}