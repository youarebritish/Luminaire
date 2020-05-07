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
            
			fieldProperties.AddProperty(new Property("status", 3125508079, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sceneAssetPath_", 1260398091, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyString", 88, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("syncTime_", 3367664428, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 144, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ownerRole_", 923291129, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 176, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ownerRoleIdx_", 1838173916, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 208, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ownerAnimationTransitionTime_", 4235658805, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 240, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target1Role_", 3828449120, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 272, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target1RoleIdx_", 1351968659, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 304, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target1AnimationTransitionTime_", 327645942, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 336, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target2Role_", 1326223403, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 368, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target2RoleIdx_", 2877077090, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 400, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target2AnimationTransitionTime_", 3046173803, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 432, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target3Role_", 371423606, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 464, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target3RoleIdx_", 427794029, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 496, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target3AnimationTransitionTime_", 3752074824, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 528, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target4Role_", 1275470425, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 560, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target4RoleIdx_", 1475875836, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 592, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("target4AnimationTransitionTime_", 2983651477, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 624, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}