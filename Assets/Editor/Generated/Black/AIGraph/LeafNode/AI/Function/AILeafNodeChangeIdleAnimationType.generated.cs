using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeChangeIdleAnimationType : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isRandom;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt maxNum;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt fixedNo;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeChangeIdleAnimationType();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeChangeIdleAnimationType", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeChangeIdleAnimationType.ObjectType, null, properties, 0, 152);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeChangeIdleAnimationType", base.GetFieldProperties(), -1715213104, -5065480);
            
			
			
			return fieldProperties;
        }

		
    }
}