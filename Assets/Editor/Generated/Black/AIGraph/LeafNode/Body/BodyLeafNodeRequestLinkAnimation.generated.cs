using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.Body
{
    public partial class BodyLeafNodeRequestLinkAnimation : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum status;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString sceneAssetPath_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat syncTime_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid ownerRole_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt ownerRoleIdx_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat ownerAnimationTransitionTime_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid target1Role_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt target1RoleIdx_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat target1AnimationTransitionTime_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid target2Role_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt target2RoleIdx_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat target2AnimationTransitionTime_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid target3Role_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt target3RoleIdx_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat target3AnimationTransitionTime_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid target4Role_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt target4RoleIdx_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat target4AnimationTransitionTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BodyLeafNodeRequestLinkAnimation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.Body.BodyLeafNodeRequestLinkAnimation", 0, Black.AIGraph.LeafNode.Body.BodyLeafNodeRequestLinkAnimation.ObjectType, null, properties, 0, 696);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.Body.BodyLeafNodeRequestLinkAnimation", base.GetFieldProperties(), 977277741, -1877427438);
            
			
			
			return fieldProperties;
        }

		
    }
}