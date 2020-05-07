using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Move
{
    public partial class BodyLeafNodeJumpChocobo : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeJumpChocobo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeJumpChocobo", 0, Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeJumpChocobo.ObjectType, null, properties, 0, 88);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Move.BodyLeafNodeJumpChocobo", base.GetFieldProperties(), -1320386390, -501880596);
            return fieldProperties;
        }

		
    }
}