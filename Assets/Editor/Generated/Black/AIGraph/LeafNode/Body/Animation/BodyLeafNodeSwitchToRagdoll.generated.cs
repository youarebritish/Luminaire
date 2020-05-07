using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body.Animation
{
    public partial class BodyLeafNodeSwitchToRagdoll : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt ragdollRange_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeSwitchToRagdoll();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.Animation.BodyLeafNodeSwitchToRagdoll", 0, Black.AIGraph.LeafNode.Body.Animation.BodyLeafNodeSwitchToRagdoll.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.Animation.BodyLeafNodeSwitchToRagdoll", base.GetFieldProperties(), -2076830288, -1970832218);
            return fieldProperties;
        }

		
    }
}