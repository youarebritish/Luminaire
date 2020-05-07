using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move.Buddy
{
    public partial class AILeafNodeArdynMove : Black.AIGraph.LeafNode.AI.Action.AILeafNodeSendMessageBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum moveMode_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeout_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat arrivalDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat speed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector targetPosition_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bEosUseActorStatusSpeed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat minMoveAroundRadius_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxMoveAroundRadius_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat minMoveAroundAngle_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxMoveAroundAngle_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bEosMoveY_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum eosMoveAroundSphereArea_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat acceleration_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxSpeed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat minSpeed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector rotation_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat distance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum state_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bUseTargetPosition_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bUseTarget_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat stuckDistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeArdynMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodeArdynMove", 0, Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodeArdynMove.ObjectType, null, properties, 0, 1008);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodeArdynMove", base.GetFieldProperties(), -1709779121, -47535153);
            
			fieldProperties.AddProperty(new Property("moveMode_", 2259767032, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 224, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("timeout_", 269585269, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 256, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("arrivalDistance_", 1191306130, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 288, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("speed_", 1253745677, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 320, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetPosition_", 3810869004, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector", 352, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetSlotType_", 102733177, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 416, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bEosUseActorStatusSpeed_", 3808340840, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 448, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("minMoveAroundRadius_", 76498666, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 480, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxMoveAroundRadius_", 16280112, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 512, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("minMoveAroundAngle_", 877511655, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 544, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxMoveAroundAngle_", 3786078233, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 576, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bEosMoveY_", 853436927, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 608, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("eosMoveAroundSphereArea_", 3892861399, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 640, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("acceleration_", 3154509670, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 672, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxSpeed_", 3235919937, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 704, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("minSpeed_", 3377264999, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 736, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotation_", 36328192, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector", 768, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("distance_", 3236486151, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 832, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("state_", 3732062219, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum", 864, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bUseTargetPosition_", 1228475831, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 896, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bUseTarget_", 1216415302, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool", 928, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("stuckDistance_", 3212067361, "SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat", 960, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}