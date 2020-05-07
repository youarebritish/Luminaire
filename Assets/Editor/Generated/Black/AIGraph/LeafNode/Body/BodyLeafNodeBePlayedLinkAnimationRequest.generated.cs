using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body
{
    public partial class BodyLeafNodeBePlayedLinkAnimationRequest : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeBePlayedLinkAnimationRequest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.BodyLeafNodeBePlayedLinkAnimationRequest", 0, Black.AIGraph.LeafNode.Body.BodyLeafNodeBePlayedLinkAnimationRequest.ObjectType, null, properties, 0, 72);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.BodyLeafNodeBePlayedLinkAnimationRequest", base.GetFieldProperties(), 979076156, 300607323);
            return fieldProperties;
        }

		
    }
}