using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function.Nifl.Reinforcement
{
    public partial class AILeafNodeSendReinforcement : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid reinforceLabel;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeSendReinforcement();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.Nifl.Reinforcement.AILeafNodeSendReinforcement", 0, Black.AIGraph.LeafNode.AI.Function.Nifl.Reinforcement.AILeafNodeSendReinforcement.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.Nifl.Reinforcement.AILeafNodeSendReinforcement", base.GetFieldProperties(), 1565194248, -1390293419);
            
			fieldProperties.AddProperty(new Property("reinforceLabel", 86690688, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 64, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}