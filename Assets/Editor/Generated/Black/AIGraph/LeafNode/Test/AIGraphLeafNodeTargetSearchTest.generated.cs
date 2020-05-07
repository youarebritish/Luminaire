using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Test
{
    public partial class AIGraphLeafNodeTargetSearchTest : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString searchLabel_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isKeepTarget_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphLeafNodeTargetSearchTest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeTargetSearchTest", 0, Black.AIGraph.LeafNode.Test.AIGraphLeafNodeTargetSearchTest.ObjectType, null, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeTargetSearchTest", base.GetFieldProperties(), -1401200935, 2146694999);
            return fieldProperties;
        }

		
    }
}