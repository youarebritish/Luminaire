using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeLabelVarSet : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum assignType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString labelName_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum valueType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool valueBool_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid valueFixid_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt valueInt_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat valueFloat_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString valueString_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeLabelVarSet();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeLabelVarSet", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeLabelVarSet.ObjectType, null, properties, 0, 392);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeLabelVarSet", base.GetFieldProperties(), -1258204231, 789660566);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("assignType_.propertyId_", 39178086, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("assignType_.indexOfLinkedProperty_", 1812445763, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("assignType_.value_", 113620807, "int", 80, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType.propertyId_", 1957557891, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType.indexOfLinkedProperty_", 2720815276, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType.value_", 913738680, "int", 112, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("labelName_.propertyId_", 3378089372, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("labelName_.indexOfLinkedProperty_", 4149800489, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("labelName_.value_", 1692578233, "Ebony.Base.String", 144, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueType_.propertyId_", 478285016, "int", 184, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueType_.indexOfLinkedProperty_", 3451442957, "int", 188, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueType_.value_", 1092633373, "int", 200, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueBool_.propertyId_", 4271503860, "int", 216, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueBool_.indexOfLinkedProperty_", 407917345, "int", 220, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueBool_.value_", 1162511425, "bool", 232, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueFixid_.propertyId_", 3003639114, "int", 248, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueFixid_.indexOfLinkedProperty_", 1037481471, "int", 252, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueFixid_.value_", 90904643, "SQEX.Ebony.Std.Fixid", 264, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueInt_.propertyId_", 2448547611, "int", 280, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueInt_.indexOfLinkedProperty_", 1918152420, "int", 284, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueInt_.value_", 1844701152, "int", 296, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueFloat_.propertyId_", 2651147834, "int", 312, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueFloat_.indexOfLinkedProperty_", 2306884719, "int", 316, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueFloat_.value_", 2921540947, "float", 328, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueString_.propertyId_", 3200459499, "int", 344, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueString_.indexOfLinkedProperty_", 4047752692, "int", 348, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("valueString_.value_", 3317228944, "Ebony.Base.String", 360, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("assignType_", 3103415457, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetSlotType", 999269404, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("labelName_", 2707696659, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString", 120, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueType_", 1693725455, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 176, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueBool_", 4048015259, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 208, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueFixid_", 1565226005, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 240, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueInt_", 1741106596, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 272, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueFloat_", 1357052645, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 304, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("valueString_", 4239990676, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString", 336, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}