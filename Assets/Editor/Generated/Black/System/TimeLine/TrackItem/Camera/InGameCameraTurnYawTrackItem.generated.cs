using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class InGameCameraTurnYawTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string yawId_;
		public string yawOffsetId_;
		public string yawSignId_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYaw turnYawData_;
		public SQEX.Ebony.Framework.TimeControl.CurveList curveList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraTurnYawTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.InGameCameraTurnYawTrackItem", 0, Black.System.TimeLine.TrackItem.Camera.InGameCameraTurnYawTrackItem.ObjectType, null, properties, 0, 232);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.InGameCameraTurnYawTrackItem", base.GetFieldProperties(), 1364207952, -935370991);
            
			fieldProperties.AddIndirectlyProperty(new Property("name_", 182823483, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startTime_", 140908163, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("duration_", 1282328598, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.isUse_", 2445327348, "bool", 144, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.rotationUseValueTypeYaw_", 22325730, "Black.Camera.RotationUseValueType", 148, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.isNotControllingYawWhenBattleHybridAndOverride_", 515634707, "bool", 152, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.bestAngleJudgeType_", 2113379217, "Black.Camera.BestAngleJudgeType", 156, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.turnInterpType_", 1581744190, "Black.Camera.RotationInterpType", 160, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.turnTimeInterpMode_", 999402040, "Black.Camera.BlendModeType", 164, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.rotationDirection_", 1579384420, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 168, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.isCalcAlwaysBehindPC_", 218596610, "bool", 172, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.isUpdateTurnEveryFrame_", 2860236819, "bool", 173, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.rotationSetAngleType_", 4027057550, "Black.Camera.SeamlessInGameSetAngleType", 176, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.turnInterpTimeYaw_", 3415929816, "float", 180, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.turnVelocityYaw_", 3429335724, "float", 184, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.turnYaw_", 3407041383, "float", 188, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.isAllowUserControlTurn_", 1386884045, "bool", 192, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.stealingPlayerDirectionInterpType_", 3872775816, "Black.Camera.StealingPlayerDirectionInterpType", 196, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.stealingPlayerDirectionInterpVelocity_", 2107978821, "float", 200, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_.propertyList_", 3952472237, "SQEX.Ebony.Std.DynamicArray< AnchorReferenceValue* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			
			
			fieldProperties.AddProperty(new Property("yawId_", 1688512606, "Ebony.Base.String", 88, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("yawOffsetId_", 1301877131, "Ebony.Base.String", 104, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("yawSignId_", 1725441593, "Ebony.Base.String", 120, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnYawData_", 1189308438, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYaw", 136, 72, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("curveList_", 1657928633, "SQEX.Ebony.Framework.TimeControl.CurveList", 208, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}