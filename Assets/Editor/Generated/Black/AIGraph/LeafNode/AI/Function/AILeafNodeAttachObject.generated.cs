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
            
			fieldProperties.AddProperty(new Property("targetSlotType_", 102733177, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetX_", 1096147371, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetY_", 2170062082, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetZ_", 2169620797, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationX_", 3350366126, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationY_", 128916183, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationZ_", 3349968768, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 248, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("joint_", 603379448, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 280, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("localRotationFlag_", 1404997709, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 312, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("releaseOnDetach_", 950754661, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 344, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useParentScale_", 2444743947, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 376, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("linkMessage_", 3469055821, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 408, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}