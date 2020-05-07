using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function.Monster
{
    public partial class AILeafNodeSetEmotion : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat emotionAverage_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isSetEmotionAverage_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat emotionValue_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isSetEmotionValue_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeSetEmotion();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.Monster.AILeafNodeSetEmotion", 0, Black.AIGraph.LeafNode.AI.Function.Monster.AILeafNodeSetEmotion.ObjectType, null, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.Monster.AILeafNodeSetEmotion", base.GetFieldProperties(), 1684818850, -1163409848);
            return fieldProperties;
        }

		
    }
}