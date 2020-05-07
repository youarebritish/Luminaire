using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.AI
{
    public partial class SequenceChangeNavigationArchetype : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint archetypeFixId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceChangeNavigationArchetype();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.AI.SequenceChangeNavigationArchetype", 0, Black.Sequence.AI.SequenceChangeNavigationArchetype.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.AI.SequenceChangeNavigationArchetype", base.GetFieldProperties(), 1264916244, -1794838633);
            
			
			
			return fieldProperties;
        }

		
    }
}