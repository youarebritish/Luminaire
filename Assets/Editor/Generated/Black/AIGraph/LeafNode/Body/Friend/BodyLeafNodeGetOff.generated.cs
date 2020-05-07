using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Friend
{
    public partial class BodyLeafNodeGetOff : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum rideTarget;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum matchTrigger_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum rootRotationType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum rootTranslationType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool freezeSource_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool freezeTarget_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool noAnimFacingRecompute_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool noAnimOriginRecompute_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool lockAnimFacing_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool lockAnimOrigin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeGetOff();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Friend.BodyLeafNodeGetOff", 0, Black.AIGraph.LeafNode.Body.Friend.BodyLeafNodeGetOff.ObjectType, null, properties, 0, 424);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Friend.BodyLeafNodeGetOff", base.GetFieldProperties(), 1500020008, -976951307);
            return fieldProperties;
        }

		
    }
}