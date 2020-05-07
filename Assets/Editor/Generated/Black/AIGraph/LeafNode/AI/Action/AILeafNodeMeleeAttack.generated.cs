using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action
{
    public partial class AILeafNodeMeleeAttack : Black.AIGraph.LeafNode.AI.Action.AILeafNodeSendMessageWithCheckCanControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackDistanceMin;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackDistanceMax;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackAngleMin;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat attackAngleMax;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool canCloseStraight;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum minRecogLv;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeMeleeAttack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.AILeafNodeMeleeAttack", 0, Black.AIGraph.LeafNode.AI.Action.AILeafNodeMeleeAttack.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.AILeafNodeMeleeAttack", base.GetFieldProperties(), 127072209, -396267751);
            
			fieldProperties.AddProperty(new Property("targetSlotType", 999269404, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 256, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("attackDistanceMin", 262773294, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 288, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("attackDistanceMax", 26606700, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 320, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("attackAngleMin", 517778460, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 352, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("attackAngleMax", 214501390, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 384, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("canCloseStraight", 3772767185, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 416, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("minRecogLv", 4294942959, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 448, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}