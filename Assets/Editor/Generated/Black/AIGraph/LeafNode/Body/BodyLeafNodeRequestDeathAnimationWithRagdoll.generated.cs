using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body
{
    public partial class BodyLeafNodeRequestDeathAnimationWithRagdoll : Black.AIGraph.LeafNode.Body.BodyLeafNodeRequestDeathAnimation
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeRequestDeathAnimationWithRagdoll();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.BodyLeafNodeRequestDeathAnimationWithRagdoll", 0, Black.AIGraph.LeafNode.Body.BodyLeafNodeRequestDeathAnimationWithRagdoll.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.BodyLeafNodeRequestDeathAnimationWithRagdoll", base.GetFieldProperties(), 268588646, 630281544);
            
			
			
			return fieldProperties;
        }

		
    }
}