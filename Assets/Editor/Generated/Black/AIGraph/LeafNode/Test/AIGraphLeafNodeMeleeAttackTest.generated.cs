using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Test
{
    public partial class AIGraphLeafNodeMeleeAttackTest : Black.AIGraph.LeafNode.Test.AIGraphLeafNodeAttackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString searchLabel_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt atkType;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphLeafNodeMeleeAttackTest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeMeleeAttackTest", 0, Black.AIGraph.LeafNode.Test.AIGraphLeafNodeMeleeAttackTest.ObjectType, null, properties, 0, 352);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeMeleeAttackTest", base.GetFieldProperties(), 2037088539, -1282072057);
            return fieldProperties;
        }

		
    }
}