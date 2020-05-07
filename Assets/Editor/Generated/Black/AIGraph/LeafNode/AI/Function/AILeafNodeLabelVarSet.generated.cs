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