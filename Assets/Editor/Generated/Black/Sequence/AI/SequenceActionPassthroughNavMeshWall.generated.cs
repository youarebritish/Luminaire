using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.AI
{
    public partial class SequenceActionPassthroughNavMeshWall : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startPassthrough_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin finishPassthrough_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPassthroughNavMeshWall();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.AI.SequenceActionPassthroughNavMeshWall", 0, Black.Sequence.AI.SequenceActionPassthroughNavMeshWall.ObjectType, null, properties, 0, 456);
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

            fieldProperties = new PropertyContainer("Black.Sequence.AI.SequenceActionPassthroughNavMeshWall", base.GetFieldProperties(), 683462896, -330601244);
            
			
			
			return fieldProperties;
        }

		
    }
}