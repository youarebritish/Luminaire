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
            
			
			
			return fieldProperties;
        }

		
    }
}