using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function.XPEC
{
    public partial class AIGraphNodeLeafResetToPlayerControl : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeLeafResetToPlayerControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.XPEC.AIGraphNodeLeafResetToPlayerControl", 0, Black.AIGraph.LeafNode.AI.Function.XPEC.AIGraphNodeLeafResetToPlayerControl.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.XPEC.AIGraphNodeLeafResetToPlayerControl", base.GetFieldProperties(), 1516939300, 1633800790);
            
			
			
			return fieldProperties;
        }

		
    }
}