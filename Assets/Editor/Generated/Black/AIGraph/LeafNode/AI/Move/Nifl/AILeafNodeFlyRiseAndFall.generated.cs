//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;

namespace Black.AIGraph.LeafNode.AI.Move.Nifl
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class AILeafNodeFlyRiseAndFall : Black.AIGraph.LeafNode.AI.Move.AILeafNodeMoveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat movingHeightOffset_;
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool useFixedHeight_;
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat movingHeightPlayerInside_;
		[UnityEngine.SerializeReference] public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxSpeedRatio_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeFlyRiseAndFall();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyRiseAndFall", 0, Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyRiseAndFall.ObjectType, Construct, properties, 0, 704);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Nifl.AILeafNodeFlyRiseAndFall", base.GetFieldProperties(), -241739656, -1608612264);
            
			fieldProperties.AddIndirectlyProperty(new Property("uid_", 2695886806, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startNodeUid_", 2715036948, "int", 20, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bDisable_", 54874740, "bool", 24, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bSkipblackBoardInitialization_", 1945287384, "bool", 25, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("urgency", 4087552372, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("urgency.propertyId_", 3859855947, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("urgency.indexOfLinkedProperty_", 1213480276, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("urgency.value_", 1928198832, "int", 80, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("desiredMoveSpeed", 1691109583, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("desiredMoveSpeed.propertyId_", 1552181272, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("desiredMoveSpeed.indexOfLinkedProperty_", 3227436621, "int", 100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("desiredMoveSpeed.value_", 1428956765, "int", 112, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveSpeed", 2868419347, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveSpeed.propertyId_", 1129499804, "int", 128, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveSpeed.indexOfLinkedProperty_", 1696924457, "int", 132, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveSpeed.value_", 4233070265, "int", 144, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveSpeedDetailed", 493539667, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 152, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveSpeedDetailed.propertyId_", 2466999644, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveSpeedDetailed.indexOfLinkedProperty_", 2823671017, "int", 164, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxMoveSpeedDetailed.value_", 1210693497, "float", 176, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("desiredArrivalSpeed", 2631783413, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 184, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("desiredArrivalSpeed.propertyId_", 2503386026, "int", 192, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("desiredArrivalSpeed.indexOfLinkedProperty_", 640312031, "int", 196, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("desiredArrivalSpeed.value_", 3105375203, "int", 208, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("arrivalMoveSpeed", 4172512298, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 216, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("arrivalMoveSpeed.propertyId_", 4162717397, "int", 224, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("arrivalMoveSpeed.indexOfLinkedProperty_", 1277206862, "int", 228, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("arrivalMoveSpeed.value_", 1496056590, "float", 240, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("atLocationRequirement", 1164093018, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 248, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("atLocationRequirement.propertyId_", 1153851813, "int", 256, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("atLocationRequirement.indexOfLinkedProperty_", 2070188382, "int", 260, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("atLocationRequirement.value_", 195269758, "int", 272, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isUseLookAtTarget", 1074173611, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 280, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isUseLookAtTarget.propertyId_", 3031201252, "int", 288, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isUseLookAtTarget.indexOfLinkedProperty_", 1857910801, "int", 292, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isUseLookAtTarget.value_", 4074624401, "bool", 304, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lookAtTargetSlotType", 2064526498, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 312, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lookAtTargetSlotType.propertyId_", 4259419645, "int", 320, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lookAtTargetSlotType.indexOfLinkedProperty_", 1440127958, "int", 324, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lookAtTargetSlotType.value_", 1151447110, "int", 336, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeout", 2549515144, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 344, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeout.propertyId_", 1014648559, "int", 352, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeout.indexOfLinkedProperty_", 311787552, "int", 356, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("timeout.value_", 3546920172, "float", 368, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moveReleaseDelay", 1525506060, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 376, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moveReleaseDelay.propertyId_", 372934675, "int", 384, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moveReleaseDelay.indexOfLinkedProperty_", 108302844, "int", 388, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moveReleaseDelay.value_", 3319868008, "int", 400, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moveMode", 494186615, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 408, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moveMode.propertyId_", 2296314128, "int", 416, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moveMode.indexOfLinkedProperty_", 1535183141, "int", 420, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("moveMode.value_", 4253764965, "int", 432, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("excludeTargetForAvoidance", 2730651779, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 440, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("excludeTargetForAvoidance.propertyId_", 1302905516, "int", 448, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("excludeTargetForAvoidance.indexOfLinkedProperty_", 450960697, "int", 452, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("excludeTargetForAvoidance.value_", 2335317993, "bool", 464, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("avoidOnIdle", 3264340485, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 472, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("avoidOnIdle.propertyId_", 2993586394, "int", 480, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("avoidOnIdle.indexOfLinkedProperty_", 78938895, "int", 484, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("avoidOnIdle.value_", 1308321843, "int", 496, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("movingHeightOffset_.propertyId_", 4061100771, "int", 576, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("movingHeightOffset_.indexOfLinkedProperty_", 32645772, "int", 580, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("movingHeightOffset_.value_", 2554443736, "float", 592, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useFixedHeight_.propertyId_", 68614601, "int", 608, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useFixedHeight_.indexOfLinkedProperty_", 1488156314, "int", 612, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useFixedHeight_.value_", 1118844202, "bool", 624, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("movingHeightPlayerInside_.propertyId_", 2546451753, "int", 640, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("movingHeightPlayerInside_.indexOfLinkedProperty_", 2627800442, "int", 644, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("movingHeightPlayerInside_.value_", 846427978, "float", 656, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxSpeedRatio_.propertyId_", 2960099111, "int", 672, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxSpeedRatio_.indexOfLinkedProperty_", 1019075288, "int", 676, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("maxSpeedRatio_.value_", 3049796244, "float", 688, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("movingHeightOffset_", 953172476, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 568, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useFixedHeight_", 3258288334, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 600, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("movingHeightPlayerInside_", 2996209838, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 632, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxSpeedRatio_", 2276114416, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 664, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new AILeafNodeFlyRiseAndFall();
        }
		
    }
}