using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node
{
    public partial class AIGraphNodeBase : SQEX.Ebony.AIGraph.AIGraphRunnableBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase> invokeListOnActivate_;
		public IList<SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase> invokeListOnDeactivate_;
		public IList<SQEX.Ebony.AIGraph.Data.ConditionData> conditions_;
		public string displayName_;
		public string displayNameJP_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.AIGraphNodeBase", 0, SQEX.Ebony.AIGraph.Node.AIGraphNodeBase.ObjectType, null, properties, 0, 160);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.AIGraphNodeBase", base.GetFieldProperties(), 1887313510, 414318621);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("invokeListOnActivate_", 2823484654, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase*, MEMORY_CATEGORY_AI_GRAPH >", 56, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddProperty(new Property("invokeListOnDeactivate_", 2891137263, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase*, MEMORY_CATEGORY_AI_GRAPH >", 72, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddProperty(new Property("conditions_", 3387481400, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.AIGraph.Data.ConditionData*, MEMORY_CATEGORY_AI_GRAPH >", 88, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("displayName_", 2066980907, "Ebony.Base.String", 104, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("displayNameJP_", 3614302633, "Ebony.Base.String", 120, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}