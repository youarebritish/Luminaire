using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move.Levia
{
    public partial class AIGraphLeafNodeLeviaMoveToPoint : Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMovePointBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector point_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat randRadiusInner_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat randRadiusOuter_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat randHeightMin_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat randHeightMax_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphLeafNodeLeviaMoveToPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveToPoint", 0, Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveToPoint.ObjectType, null, properties, 0, 1248);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveToPoint", base.GetFieldProperties(), -1552003355, 1543745075);
            return fieldProperties;
        }

		
    }
}