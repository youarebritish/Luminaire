using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.BT.Decorator
{
    public partial class AIGraphNodeBTDecoratorTerritoryGate : SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isCheckOnTerritory_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeOutOfTerritory_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isCheckTargetOnTerritory_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isCheckTargetOnBattleArea_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTDecoratorTerritoryGate();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorTerritoryGate", 0, SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorTerritoryGate.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.BT.Decorator.AIGraphNodeBTDecoratorTerritoryGate", base.GetFieldProperties(), 713232689, 1021477227);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("invokeListOnActivate_", 2823484654, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase*, MEMORY_CATEGORY_AI_GRAPH >", 56, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("invokeListOnDeactivate_", 2891137263, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase*, MEMORY_CATEGORY_AI_GRAPH >", 72, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("conditions_", 3387481400, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Data.ConditionData*, MEMORY_CATEGORY_AI_GRAPH >", 88, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddIndirectlyProperty(new Property("displayName_", 2066980907, "Ebony.Base.String", 104, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("displayNameJP_", 3614302633, "Ebony.Base.String", 120, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("parentNode_", 1131722510, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTBase*, MEMORY_CATEGORY_AI_GRAPH >", 160, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("childList_", 1838097394, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTBase*, MEMORY_CATEGORY_AI_GRAPH >", 176, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isCheckOnTerritory_.propertyId_", 2722359646, "int", 208, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isCheckOnTerritory_.indexOfLinkedProperty_", 3945273851, "int", 212, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isCheckOnTerritory_.value_", 2591329775, "bool", 224, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeOutOfTerritory_.propertyId_", 3734913257, "int", 240, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeOutOfTerritory_.indexOfLinkedProperty_", 2959735098, "int", 244, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeOutOfTerritory_.value_", 255143434, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isCheckTargetOnTerritory_.propertyId_", 1049167803, "int", 272, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isCheckTargetOnTerritory_.indexOfLinkedProperty_", 2351796740, "int", 276, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isCheckTargetOnTerritory_.value_", 640490304, "bool", 288, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isCheckTargetOnBattleArea_.propertyId_", 805203610, "int", 304, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isCheckTargetOnBattleArea_.indexOfLinkedProperty_", 2345839311, "int", 308, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isCheckTargetOnBattleArea_.value_", 3311158771, "bool", 320, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType_.propertyId_", 148178158, "int", 336, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType_.indexOfLinkedProperty_", 1898007691, "int", 340, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType_.value_", 340910751, "int", 352, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("isCheckOnTerritory_", 4160427017, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 200, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeOutOfTerritory_", 805934574, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 232, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCheckTargetOnTerritory_", 2757722308, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 264, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCheckTargetOnBattleArea_", 3836270661, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 296, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetSlotType_", 102733177, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 328, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}