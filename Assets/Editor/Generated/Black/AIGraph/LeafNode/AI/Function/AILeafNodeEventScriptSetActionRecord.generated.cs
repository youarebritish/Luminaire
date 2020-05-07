using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeEventScriptSetActionRecord : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum slotType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum actionType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeEventScriptSetActionRecord();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeEventScriptSetActionRecord", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeEventScriptSetActionRecord.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeEventScriptSetActionRecord", base.GetFieldProperties(), 1908511852, 1088593207);
            return fieldProperties;
        }

		
    }
}