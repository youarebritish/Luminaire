using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Team
{
    public partial class SequenceActionFluctuationTeamMember : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin teamActorIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorsIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outOPin_;
		public int fluctuationType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionFluctuationTeamMember();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Team.SequenceActionFluctuationTeamMember", 0, Black.Sequence.Action.Level.Team.SequenceActionFluctuationTeamMember.ObjectType, null, properties, 0, 552);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Team.SequenceActionFluctuationTeamMember", base.GetFieldProperties(), 1148841415, -1560785249);
            
			
			
			return fieldProperties;
        }

		
    }
}