using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Test
{
    public partial class AIGraphLeafNodeRelativeTargetMoveTest : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString searchLabel_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat arrivalInnnerDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat arrivalOuterDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat failedDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat moveSpeed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool isMoveY_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphLeafNodeRelativeTargetMoveTest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeRelativeTargetMoveTest", 0, Black.AIGraph.LeafNode.Test.AIGraphLeafNodeRelativeTargetMoveTest.ObjectType, null, properties, 0, 848);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Test.AIGraphLeafNodeRelativeTargetMoveTest", base.GetFieldProperties(), -1899808779, -1188885355);
            return fieldProperties;
        }

		
    }
}