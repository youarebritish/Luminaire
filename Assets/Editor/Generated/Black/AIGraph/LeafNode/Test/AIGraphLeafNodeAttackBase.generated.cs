using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Test
{
    public partial class AIGraphLeafNodeAttackBase : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackDistanceMin_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackDistanceMax_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackAngleMin_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackAngleMax_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool checkShielding_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphLeafNodeAttackBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeAttackBase", 0, Black.AIGraph.LeafNode.Test.AIGraphLeafNodeAttackBase.ObjectType, null, properties, 0, 216);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeAttackBase", base.GetFieldProperties(), 641855256, 1751545823);
            
			
			
			return fieldProperties;
        }

		
    }
}