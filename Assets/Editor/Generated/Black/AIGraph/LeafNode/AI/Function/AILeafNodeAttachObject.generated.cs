using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeAttachObject : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetX_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetY_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetZ_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat rotationX_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat rotationY_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat rotationZ_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid joint_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool localRotationFlag_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool releaseOnDetach_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool useParentScale_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool linkMessage_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeAttachObject();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeAttachObject", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeAttachObject.ObjectType, null, properties, 0, 440);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeAttachObject", base.GetFieldProperties(), 2052133254, -1005811823);
            
			
			
			return fieldProperties;
        }

		
    }
}