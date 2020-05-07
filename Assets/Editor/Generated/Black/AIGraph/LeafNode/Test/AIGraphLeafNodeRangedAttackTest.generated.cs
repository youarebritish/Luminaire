using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Test
{
    public partial class AIGraphLeafNodeRangedAttackTest : Black.AIGraph.LeafNode.Test.AIGraphLeafNodeAttackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString searchLabel_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum shotType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt firingCountMin_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt firingCountMax_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphLeafNodeRangedAttackTest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeRangedAttackTest", 0, Black.AIGraph.LeafNode.Test.AIGraphLeafNodeRangedAttackTest.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeRangedAttackTest", base.GetFieldProperties(), 587368796, -1197738766);
            return fieldProperties;
        }

		
    }
}