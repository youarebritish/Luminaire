using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.AI
{
    public partial class SequenceFindNearestNavMesh : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint archetypeFixId_;
		public float searchRadius_;
		public float searchHeight_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputPosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputPosition_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceFindNearestNavMesh();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.AI.SequenceFindNearestNavMesh", 0, Black.Sequence.AI.SequenceFindNearestNavMesh.ObjectType, null, properties, 0, 576);
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

            fieldProperties = new PropertyContainer("Black.Sequence.AI.SequenceFindNearestNavMesh", base.GetFieldProperties(), 380447505, -29099089);
            return fieldProperties;
        }

		
    }
}