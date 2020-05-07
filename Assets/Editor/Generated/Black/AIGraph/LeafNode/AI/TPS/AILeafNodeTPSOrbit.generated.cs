using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.TPS
{
    public partial class AILeafNodeTPSOrbit : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat innerRadius;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum priority;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat arrivalDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat failedDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat minimumDistance;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool ReservePoint;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat moveSpeed;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeTPSOrbit();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.TPS.AILeafNodeTPSOrbit", 0, Black.AIGraph.LeafNode.AI.TPS.AILeafNodeTPSOrbit.ObjectType, null, properties, 0, 832);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.TPS.AILeafNodeTPSOrbit", base.GetFieldProperties(), -1420431087, 595362249);
            
			
			
			return fieldProperties;
        }

		
    }
}