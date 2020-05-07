using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Function
{
    public partial class BodyLeafNodeShotProjectile : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid attackID;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isUseMessage;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isUseRecoiling;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum recoilAimControlID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeShotProjectile();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Function.BodyLeafNodeShotProjectile", 0, Black.AIGraph.LeafNode.Body.Function.BodyLeafNodeShotProjectile.ObjectType, null, properties, 0, 192);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Function.BodyLeafNodeShotProjectile", base.GetFieldProperties(), -501115536, -142222817);
            return fieldProperties;
        }

		
    }
}