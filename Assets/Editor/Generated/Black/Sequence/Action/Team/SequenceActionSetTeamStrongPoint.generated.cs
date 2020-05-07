using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Team
{
    public partial class SequenceActionSetTeamStrongPoint : Black.Sequence.Action.Team.SequenceActionTeamBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin strPoint_;
		public string teamName_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetTeamStrongPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Team.SequenceActionSetTeamStrongPoint", 0, Black.Sequence.Action.Team.SequenceActionSetTeamStrongPoint.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Team.SequenceActionSetTeamStrongPoint", base.GetFieldProperties(), 1003815, -2041962833);
            return fieldProperties;
        }

		
    }
}