using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Test
{
    public partial class AIGraphLeafNodeThrowGranadeTest : Black.AIGraph.LeafNode.Test.AIGraphLeafNodeAttackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString searchLabel_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphLeafNodeThrowGranadeTest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeThrowGranadeTest", 0, Black.AIGraph.LeafNode.Test.AIGraphLeafNodeThrowGranadeTest.ObjectType, null, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeThrowGranadeTest", base.GetFieldProperties(), -2055239737, 663437621);
            
			
			
			return fieldProperties;
        }

		
    }
}