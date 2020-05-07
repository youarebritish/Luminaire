using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Ambient
{
    public partial class AILeafNodeJoinAmbientGroup : Black.AIGraph.LeafNode.AI.Action.Ambient.AILeafNodeAmbientBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum target_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeJoinAmbientGroup();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Ambient.AILeafNodeJoinAmbientGroup", 0, Black.AIGraph.LeafNode.AI.Action.Ambient.AILeafNodeJoinAmbientGroup.ObjectType, null, properties, 0, 104);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Ambient.AILeafNodeJoinAmbientGroup", base.GetFieldProperties(), -1459395724, 265630914);
            
			fieldProperties.AddProperty(new Property("target_", 1693858869, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 64, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}