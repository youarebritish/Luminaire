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
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isMessagePassThrough.propertyId_", 3402240861, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isMessagePassThrough.indexOfLinkedProperty_", 1434567734, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isMessagePassThrough.value_", 1881529318, "bool", 80, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animMsg.propertyId_", 1752564102, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animMsg.indexOfLinkedProperty_", 2920181987, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animMsg.value_", 3947388071, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animLayer.propertyId_", 3891205898, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animLayer.indexOfLinkedProperty_", 1976640447, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animLayer.value_", 1792715523, "SQEX.Ebony.Std.Fixid", 144, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isLayerFinishWithAnimFinish.propertyId_", 1264499592, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isLayerFinishWithAnimFinish.indexOfLinkedProperty_", 3680796285, "int", 164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isLayerFinishWithAnimFinish.value_", 1896907629, "bool", 176, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("IsUseMessage.propertyId_", 2290329324, "int", 192, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("IsUseMessage.indexOfLinkedProperty_", 2432086137, "int", 196, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("IsUseMessage.value_", 3423182121, "bool", 208, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("deleteBlendTime.propertyId_", 1125159759, "int", 224, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("deleteBlendTime.indexOfLinkedProperty_", 4000135552, "int", 228, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("deleteBlendTime.value_", 1671993612, "float", 240, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("isMessagePassThrough", 3038903938, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("animMsg", 2005261249, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("animLayer", 382561877, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isLayerFinishWithAnimFinish", 2423494943, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsUseMessage", 2247550531, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("deleteBlendTime", 2824128872, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}