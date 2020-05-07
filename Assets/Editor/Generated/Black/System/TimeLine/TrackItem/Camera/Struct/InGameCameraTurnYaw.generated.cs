using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraTurnYaw : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isUse_;
		public int rotationUseValueTypeYaw_;
		public bool isNotControllingYawWhenBattleHybridAndOverride_;
		public int bestAngleJudgeType_;
		public int turnInterpType_;
		public int turnTimeInterpMode_;
		public int rotationDirection_;
		public bool isCalcAlwaysBehindPC_;
		public bool isUpdateTurnEveryFrame_;
		public int rotationSetAngleType_;
		public float turnInterpTimeYaw_;
		public float turnVelocityYaw_;
		public float turnYaw_;
		public bool isAllowUserControlTurn_;
		public int stealingPlayerDirectionInterpType_;
		public float stealingPlayerDirectionInterpVelocity_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraTurnYaw();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYaw", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYaw.ObjectType, null, properties, 0, 72);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYaw", base.GetFieldProperties(), 205736526, -2080539401);
            
			
			
			fieldProperties.AddProperty(new Property("isUse_", 318966273, "bool", 8, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationUseValueTypeYaw_", 1145603407, "Black.Camera.RotationUseValueType", 12, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNotControllingYawWhenBattleHybridAndOverride_", 3150554520, "bool", 16, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bestAngleJudgeType_", 492051394, "Black.Camera.BestAngleJudgeType", 20, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnInterpType_", 1040511941, "Black.Camera.RotationInterpType", 24, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnTimeInterpMode_", 4035728667, "Black.Camera.BlendModeType", 28, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationDirection_", 1052729957, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 32, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCalcAlwaysBehindPC_", 1236185, "bool", 36, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUpdateTurnEveryFrame_", 3599398000, "bool", 37, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationSetAngleType_", 7143229, "Black.Camera.SeamlessInGameSetAngleType", 40, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnInterpTimeYaw_", 2306315865, "float", 44, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnVelocityYaw_", 1813046065, "float", 48, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("turnYaw_", 2729104726, "float", 52, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("isAllowUserControlTurn_", 4125811390, "bool", 56, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("stealingPlayerDirectionInterpType_", 3676963821, "Black.Camera.StealingPlayerDirectionInterpType", 60, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("stealingPlayerDirectionInterpVelocity_", 3374573324, "float", 64, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			
			
			return fieldProperties;
        }

		
    }
}