using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode
{
    public partial class AIGraphLeafNodeUserCreateTest : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat time;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt atkType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid questId;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid animBBParam;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid bodyMessage;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum runStatus_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphLeafNodeUserCreateTest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AIGraphLeafNodeUserCreateTest", 0, Black.AIGraph.LeafNode.AIGraphLeafNodeUserCreateTest.ObjectType, null, properties, 0, 248);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AIGraphLeafNodeUserCreateTest", base.GetFieldProperties(), -1915527401, -1917051943);
            
			
			
			return fieldProperties;
        }

		
    }
}