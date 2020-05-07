using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move.Levia
{
    public partial class AIGraphLeafNodeLeviaMoveToTPSPoint : Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMovePointBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphLeafNodeLeviaMoveToTPSPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveToTPSPoint", 0, Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveToTPSPoint.ObjectType, null, properties, 0, 1088);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveToTPSPoint", base.GetFieldProperties(), -1184944784, 1798992196);
            return fieldProperties;
        }

		
    }
}