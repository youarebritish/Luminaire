using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeSetLookAtTarget : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isSetAllSlot_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum lookAtSlot_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum atIKPointType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool lookAtEnable_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum lookAtControlType;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeSetLookAtTarget();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeSetLookAtTarget", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeSetLookAtTarget.ObjectType, null, properties, 0, 248);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeSetLookAtTarget", base.GetFieldProperties(), -222228901, 868504659);
            
			
			
			return fieldProperties;
        }

		
    }
}