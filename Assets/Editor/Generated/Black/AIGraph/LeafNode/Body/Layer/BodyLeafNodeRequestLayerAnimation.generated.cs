using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Layer
{
    public partial class BodyLeafNodeRequestLayerAnimation : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isMessagePassThrough;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid animMsg;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid animLayer;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isLayerFinishWithAnimFinish;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool IsUseMessage;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat deleteBlendTime;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeRequestLayerAnimation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Layer.BodyLeafNodeRequestLayerAnimation", 0, Black.AIGraph.LeafNode.Body.Layer.BodyLeafNodeRequestLayerAnimation.ObjectType, null, properties, 0, 272);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Layer.BodyLeafNodeRequestLayerAnimation", base.GetFieldProperties(), 1398344418, 1217014678);
            return fieldProperties;
        }

		
    }
}