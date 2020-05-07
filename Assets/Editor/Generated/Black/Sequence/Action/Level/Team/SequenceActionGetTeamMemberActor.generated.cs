using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Team
{
    public partial class SequenceActionGetTeamMemberActor : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin teamActorIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorListOPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetTeamMemberActor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Team.SequenceActionGetTeamMemberActor", 0, Black.Sequence.Action.Level.Team.SequenceActionGetTeamMemberActor.ObjectType, null, properties, 0, 352);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Team.SequenceActionGetTeamMemberActor", base.GetFieldProperties(), -88673385, 236735479);
            
			
			
			return fieldProperties;
        }

		
    }
}