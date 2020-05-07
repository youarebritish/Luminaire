using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.CondNode.AI
{
    public partial class AILeafNodeCheckDestinationOfAnimation : SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorCondition
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt animClipRowID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeCheckDestinationOfAnimation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.CondNode.AI.AILeafNodeCheckDestinationOfAnimation", 0, Black.AIGraph.CondNode.AI.AILeafNodeCheckDestinationOfAnimation.ObjectType, null, properties, 0, 384);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.CondNode.AI.AILeafNodeCheckDestinationOfAnimation", base.GetFieldProperties(), 461853756, -1676742277);
            return fieldProperties;
        }

		
    }
}