using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Team
{
    public partial class SequenceActionCreateTeamLabel : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin end_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failure_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin position_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueTeamLabel_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inInitialTactics_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValueReinforcePoint_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inEntryCorps_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin team_;
		public string teamName_;
		public uint teamLabel_;
		public string initalTactics;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCreateTeamLabel();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Team.SequenceActionCreateTeamLabel", 0, Black.Sequence.Action.Level.Team.SequenceActionCreateTeamLabel.ObjectType, null, properties, 0, 1168);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Team.SequenceActionCreateTeamLabel", base.GetFieldProperties(), 1707968873, 2131105249);
            
			
			
			return fieldProperties;
        }

		
    }
}