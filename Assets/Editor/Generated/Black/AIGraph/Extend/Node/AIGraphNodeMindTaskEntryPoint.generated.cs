using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Node
{
    public partial class AIGraphNodeMindTaskEntryPoint : SQEX.Ebony.AIGraph.Node.AIGraphNodeEntryPoint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint mindTaskId_;
		public int mindTaskNodeIndex_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeMindTaskEntryPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Node.AIGraphNodeMindTaskEntryPoint", 0, Black.AIGraph.Extend.Node.AIGraphNodeMindTaskEntryPoint.ObjectType, null, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Node.AIGraphNodeMindTaskEntryPoint", base.GetFieldProperties(), 1162833676, -1592462670);
            return fieldProperties;
        }

		
    }
}