using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Team
{
    public partial class SequenceVariableLabeledTeam : Black.Sequence.Actor.SequenceVariableLabeledActor
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin leader_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin memberCount_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableLabeledTeam();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Team.SequenceVariableLabeledTeam", 0, Black.Sequence.Actor.AI.Team.SequenceVariableLabeledTeam.ObjectType, null, properties, 0, 1136);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Team.SequenceVariableLabeledTeam", base.GetFieldProperties(), -571505507, -352363585);
            
			fieldProperties.AddProperty(new Property("leader_", 455491169, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 960, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("memberCount_", 865408551, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1048, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}