using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move.Buddy
{
    public partial class AILeafNodeFormationMoveBuddy : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum followTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool useLevelSetting;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid formationType;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeFormationMoveBuddy();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodeFormationMoveBuddy", 0, Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodeFormationMoveBuddy.ObjectType, null, properties, 0, 160);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodeFormationMoveBuddy", base.GetFieldProperties(), -1031674592, 732666445);
            return fieldProperties;
        }

		
    }
}