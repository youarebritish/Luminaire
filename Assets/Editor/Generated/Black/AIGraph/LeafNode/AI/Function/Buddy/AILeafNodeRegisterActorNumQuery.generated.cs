using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function.Buddy
{
    public partial class AILeafNodeRegisterActorNumQuery : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt queryIndex;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum distType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum distTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat minDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum angleType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum angleTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum startDirection;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat startAngle;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum endDirection;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat endAngle;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkEnemyA;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkEnemyB;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkEnemyC;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkEnemyD;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkNoctis;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkBuddy;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeRegisterActorNumQuery();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.Buddy.AILeafNodeRegisterActorNumQuery", 0, Black.AIGraph.LeafNode.AI.Function.Buddy.AILeafNodeRegisterActorNumQuery.ObjectType, null, properties, 0, 600);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.Buddy.AILeafNodeRegisterActorNumQuery", base.GetFieldProperties(), 2028584718, 64550806);
            return fieldProperties;
        }

		
    }
}