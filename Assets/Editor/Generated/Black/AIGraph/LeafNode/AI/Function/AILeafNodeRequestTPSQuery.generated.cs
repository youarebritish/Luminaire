using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeRequestTPSQuery : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid fixid;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum priority;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool Reserve;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool OverrideReservationSize;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat ReservationSize;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt ValidationLimit;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat distanceCoefficient;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeRequestTPSQuery();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeRequestTPSQuery", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeRequestTPSQuery.ObjectType, null, properties, 0, 296);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeRequestTPSQuery", base.GetFieldProperties(), 2096236001, 1327612314);
            
			
			
			return fieldProperties;
        }

		
    }
}