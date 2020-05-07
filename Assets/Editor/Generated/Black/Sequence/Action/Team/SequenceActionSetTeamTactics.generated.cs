using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Team
{
    public partial class SequenceActionSetTeamTactics : Black.Sequence.Action.Team.SequenceActionTeamBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inSetTeam_;
		public string teamName_;
		public string teamType_;
		public uint tacticsID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetTeamTactics();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Team.SequenceActionSetTeamTactics", 0, Black.Sequence.Action.Team.SequenceActionSetTeamTactics.ObjectType, null, properties, 0, 504);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Team.SequenceActionSetTeamTactics", base.GetFieldProperties(), -39948143, -1959313814);
            return fieldProperties;
        }

		
    }
}