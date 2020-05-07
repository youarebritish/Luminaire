using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeRouteMove : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat moveSpeed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid routeId_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt optionsType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bIgnoreNavmesh_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum useRouteSlot_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool onArrivedNextPointFrame_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeRouteMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeRouteMove", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeRouteMove.ObjectType, null, properties, 0, 1136);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeRouteMove", base.GetFieldProperties(), 714106266, -1592865893);
            
			
			
			return fieldProperties;
        }

		
    }
}