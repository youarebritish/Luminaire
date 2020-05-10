//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;

namespace Black.AIGraph.Extend.Node.BT
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class AIGraphNodeBTBehaviorMindTaskTray : SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid id;
		public int nodeIndex_;
		public int layer_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTBehaviorMindTaskTray();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Node.BT.AIGraphNodeBTBehaviorMindTaskTray", 0, Black.AIGraph.Extend.Node.BT.AIGraphNodeBTBehaviorMindTaskTray.ObjectType, Construct, properties, 0, 376);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Node.BT.AIGraphNodeBTBehaviorMindTaskTray", base.GetFieldProperties(), 406068198, 209540399);
            
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
			fieldProperties.AddIndirectlyProperty(new Property("id.propertyId_", 3123770551, "int", 208, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("id.indexOfLinkedProperty_", 3124156648, "int", 212, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("id.value_", 2062651460, "SQEX.Ebony.Std.Fixid", 224, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("id", 926444256, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 200, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("nodeIndex_", 207217860, "int", 232, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("layer_", 3015166475, "SQEX.Ebony.AIGraph.AIGRAPH_LAYER", 236, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AIGraphNodeBTBehaviorMindTaskTray();
        }
		
    }
}