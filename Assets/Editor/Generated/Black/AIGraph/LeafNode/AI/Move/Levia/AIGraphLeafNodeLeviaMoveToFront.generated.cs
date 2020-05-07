using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move.Levia
{
    public partial class AIGraphLeafNodeLeviaMoveToFront : Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat distance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool xzDirection_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphLeafNodeLeviaMoveToFront();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveToFront", 0, Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveToFront.ObjectType, null, properties, 0, 1080);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Levia.AIGraphLeafNodeLeviaMoveToFront", base.GetFieldProperties(), -850243896, 1324109705);
            
			
			
			return fieldProperties;
        }

		
    }
}