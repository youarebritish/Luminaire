using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeSphereCast : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector startPosition_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector startOffset_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector endPosition_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector endOffset_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector direction_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat distance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat sphereRadius_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool hasHit_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector hitPosition_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat hitDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeout_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeSphereCast();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeSphereCast", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeSphereCast.ObjectType, null, properties, 0, 624);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeSphereCast", base.GetFieldProperties(), -150567363, -158273098);
            return fieldProperties;
        }

		
    }
}