using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Action.Monster
{
    public partial class AILeafNodeMonMeleeAttack : Black.AIGraph.LeafNode.AI.Action.AILeafNodeMeleeAttack
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt monActionType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt dirType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeMonMeleeAttack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Action.Monster.AILeafNodeMonMeleeAttack", 0, Black.AIGraph.LeafNode.AI.Action.Monster.AILeafNodeMonMeleeAttack.ObjectType, null, properties, 0, 544);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Action.Monster.AILeafNodeMonMeleeAttack", base.GetFieldProperties(), -892295203, 750964416);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bodyMessage_", 2871992657, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bodyMessage_.propertyId_", 1665512566, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bodyMessage_.indexOfLinkedProperty_", 213968595, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bodyMessage_.value_", 3675438519, "SQEX.Ebony.Std.Fixid", 80, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animBBParamId_", 3184568821, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animBBParamId_.propertyId_", 693213610, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animBBParamId_.indexOfLinkedProperty_", 2512565471, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("animBBParamId_.value_", 1511527907, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actionType_", 3416588776, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actionType_.propertyId_", 2216911823, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actionType_.indexOfLinkedProperty_", 1950809856, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("actionType_.value_", 2585656972, "int", 144, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkBodyCanRecieveMessage_", 227899608, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkBodyCanRecieveMessage_.propertyId_", 36675359, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkBodyCanRecieveMessage_.indexOfLinkedProperty_", 3905631440, "int", 164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("checkBodyCanRecieveMessage_.value_", 1870054204, "bool", 176, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("messageTimer", 2433886869, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("messageTimer.propertyId_", 3655914442, "int", 192, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("messageTimer.indexOfLinkedProperty_", 4003235199, "int", 196, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("messageTimer.value_", 3411412931, "float", 208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isFinishWhenCanControl", 2477078549, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 224, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isFinishWhenCanControl.propertyId_", 2415290698, "int", 232, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isFinishWhenCanControl.indexOfLinkedProperty_", 460120575, "int", 236, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isFinishWhenCanControl.value_", 2782807107, "bool", 248, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType", 999269404, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 256, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType.propertyId_", 1957557891, "int", 264, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType.indexOfLinkedProperty_", 2720815276, "int", 268, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("targetSlotType.value_", 913738680, "int", 280, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackDistanceMin", 262773294, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 288, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackDistanceMin.propertyId_", 3524665001, "int", 296, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackDistanceMin.indexOfLinkedProperty_", 3644347898, "int", 300, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackDistanceMin.value_", 502243274, "float", 312, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackDistanceMax", 26606700, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 320, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackDistanceMax.propertyId_", 875111667, "int", 328, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackDistanceMax.indexOfLinkedProperty_", 1850152796, "int", 332, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackDistanceMax.value_", 3399542024, "float", 344, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackAngleMin", 517778460, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 352, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackAngleMin.propertyId_", 166493827, "int", 360, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackAngleMin.indexOfLinkedProperty_", 2969120940, "int", 364, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackAngleMin.value_", 1776116664, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackAngleMax", 214501390, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 384, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackAngleMax.propertyId_", 3583654793, "int", 392, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackAngleMax.indexOfLinkedProperty_", 2859201370, "int", 396, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("attackAngleMax.value_", 2858903018, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("canCloseStraight", 3772767185, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 416, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("canCloseStraight.propertyId_", 2041669366, "int", 424, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("canCloseStraight.indexOfLinkedProperty_", 565944915, "int", 428, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("canCloseStraight.value_", 4007631159, "bool", 440, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("minRecogLv", 4294942959, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 448, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("minRecogLv.propertyId_", 3604382776, "int", 456, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("minRecogLv.indexOfLinkedProperty_", 3582785005, "int", 460, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("minRecogLv.value_", 2630659773, "int", 472, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("monActionType_.propertyId_", 4224258019, "int", 488, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("monActionType_.indexOfLinkedProperty_", 2788010380, "int", 492, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("monActionType_.value_", 3581771480, "int", 504, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dirType_.propertyId_", 1780478958, "int", 520, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dirType_.indexOfLinkedProperty_", 1227747723, "int", 524, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("dirType_.value_", 633030559, "int", 536, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("monActionType_", 878372604, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 480, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("dirType_", 820294777, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 512, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}