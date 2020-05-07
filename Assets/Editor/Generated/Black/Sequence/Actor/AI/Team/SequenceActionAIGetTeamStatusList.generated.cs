using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Team
{
    public partial class SequenceActionAIGetTeamStatusList : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin list_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin count_;
		public int paramType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIGetTeamStatusList();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Team.SequenceActionAIGetTeamStatusList", 0, Black.Sequence.Actor.AI.Team.SequenceActionAIGetTeamStatusList.ObjectType, null, properties, 0, 664);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Team.SequenceActionAIGetTeamStatusList", base.GetFieldProperties(), 492757162, -1967088151);
            
			
			
			return fieldProperties;
        }

		
    }
}