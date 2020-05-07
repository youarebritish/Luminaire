using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Function
{
    public partial class AILeafNodeSpawnProp : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetX_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetY_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetZ_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat rotationX_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat rotationY_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat rotationZ_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid characterEntry_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool useLocalCoordinates_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool rayCastForGround_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool hide_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeSpawnProp();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Function.AILeafNodeSpawnProp", 0, Black.AIGraph.LeafNode.AI.Function.AILeafNodeSpawnProp.ObjectType, null, properties, 0, 424);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Function.AILeafNodeSpawnProp", base.GetFieldProperties(), 1498203738, -192958611);
            
			fieldProperties.AddProperty(new Property("targetSlotType_", 102733177, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetX_", 1096147371, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetY_", 2170062082, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetZ_", 2169620797, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationX_", 3350366126, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationY_", 128916183, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationZ_", 3349968768, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 248, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("characterEntry_", 2102739073, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 280, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useLocalCoordinates_", 3727145563, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 312, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rayCastForGround_", 3642012813, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 352, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("hide_", 1928034806, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 384, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}