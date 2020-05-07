using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionCreateTeam : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin teamNamePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin teamNameIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin teamParamIdPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failure_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin createdTeam_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin teamLeader_;
		public uint teamParamID_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actors_;
		public string teamName_;
		public string teamType_;
		public uint teamNameId_;
		public uint teamTypeId_;
		public bool bAutoTeamMerge_;
		public uint tacticsID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCreateTeam();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionCreateTeam", 0, Black.Sequence.Action.Level.SequenceActionCreateTeam.ObjectType, null, properties, 0, 1072);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionCreateTeam", base.GetFieldProperties(), 1028846188, 1224629157);
            return fieldProperties;
        }

		
    }
}