using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeDetachObject : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool forceReleaseOnDetach_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool detachEverything_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool rayCastForGround_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeDetachObject();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeDetachObject", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeDetachObject.ObjectType, null, properties, 0, 208);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeDetachObject", base.GetFieldProperties(), 276922715, -1340899740);
            return fieldProperties;
        }

		
    }
}