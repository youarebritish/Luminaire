using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Layer
{
    public partial class BodyLeafNodeActivateLayerAnimation : Black.AIGraph.LeafNode.Body.Layer.BodyLeafNodeRequestLayerAnimation
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString graphId;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat beginBlendTime;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isMirrored;
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

            var dummy = new BodyLeafNodeActivateLayerAnimation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Layer.BodyLeafNodeActivateLayerAnimation", 0, Black.AIGraph.LeafNode.Body.Layer.BodyLeafNodeActivateLayerAnimation.ObjectType, null, properties, 0, 688);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Layer.BodyLeafNodeActivateLayerAnimation", base.GetFieldProperties(), -1151088719, 419368791);
            
			
			
			return fieldProperties;
        }

		
    }
}