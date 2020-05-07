using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action
{
    public partial class AILeafNodeExecMoveAction : Black.AIGraph.LeafNode.AI.Action.AILeafNodeSendMessageWithCheckCanControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum gotoTargetType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum actionTargetType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum extraTargetType;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeExecMoveAction();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.AILeafNodeExecMoveAction", 0, Black.AIGraph.LeafNode.AI.Action.AILeafNodeExecMoveAction.ObjectType, null, properties, 0, 400);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.AILeafNodeExecMoveAction", base.GetFieldProperties(), 2011370451, 1606478571);
            
			fieldProperties.AddProperty(new Property("gotoTargetType", 1612474735, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 256, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("actionTargetType", 2953920946, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 288, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("extraTargetType", 1584846196, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 320, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}