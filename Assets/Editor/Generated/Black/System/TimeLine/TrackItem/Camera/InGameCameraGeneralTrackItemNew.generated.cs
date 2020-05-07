using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class InGameCameraGeneralTrackItemNew : Black.System.TimeLine.TrackItem.BlendTrackItemBaseNoResource
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string lastViewKeepId_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralNew generalData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraGeneralTrackItemNew();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.InGameCameraGeneralTrackItemNew", 0, Black.System.TimeLine.TrackItem.Camera.InGameCameraGeneralTrackItemNew.ObjectType, null, properties, 0, 712);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.InGameCameraGeneralTrackItemNew", base.GetFieldProperties(), 1472060458, -2078175781);
            
			fieldProperties.AddIndirectlyProperty(new Property("name_", 182823483, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startTime_", 140908163, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("duration_", 1282328598, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blendRate_", 930283391, "float", 88, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startInterpTime_", 1816728177, "float", 92, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endInterpTime_", 654645938, "float", 96, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_", 1657928633, "SQEX.Ebony.Framework.TimeControl.CurveList", 104, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_.propertyList_", 3952472237, "SQEX.Ebony.Std.DynamicArray< AnchorReferenceValue* >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.filterLevel_", 2974887459, "Black.Camera.CameraFilterLevel", 152, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessGroupId_", 1391187118, "SQEX.Ebony.Std.Fixid", 156, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessId_", 2277146161, "Ebony.Base.String", 160, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.stopFilterType_", 2710847493, "Black.Camera.StopCameraFilterType", 176, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isEnableSwitchOtherCamera_", 3675368379, "bool", 180, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isEnableForceStopOtherCamera_", 3275571906, "bool", 181, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isEventSeamless_", 3391679914, "bool", 182, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpMode_", 1966776805, "Black.Camera.SeamlessInterpMode", 184, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneReleaseMode_", 3001437251, "Black.Camera.SeamlessInterpCloneReleaseMode", 188, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneAutoReleaseTime_", 2407461802, "float", 192, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_", 1504067211, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone", 200, 40, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToSeamlessCloneReleasePreset_", 1050619844, "Black.Camera.SeamlessCloneReleasePreset", 208, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalCoordInterpType_", 2920268546, "Black.Camera.CoordInterpType", 212, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalInterpTime_", 2875691494, "float", 216, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalCameraTime1_", 3447573160, "float", 220, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalCameraTime2_", 3447720255, "float", 224, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalCameraAccel_", 1662314156, "float", 228, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalInterpBlendMode_", 4064873013, "SQEX.Ebony.Framework.TimeControl.InterpMode", 232, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_", 3020087619, "Black.Camera.Struct.CameraControlTurn", 248, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.mode", 538119600, "Black.Camera.Struct.CameraControlTurnMode", 256, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.isUseAutoAdjustMode_", 3719792590, "bool", 260, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.isUseAutoAdjustAngleMode_", 1856784151, "bool", 261, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.isUseDefaultBrakeParam_", 4060082236, "bool", 262, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.controlTurnVelocity_", 2126948637, "float", 264, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.backToDefaultTurnVelocity_", 2575951811, "float", 268, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.yawMin_", 581279739, "float", 272, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.yawMax_", 2349539057, "float", 276, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.tiltMin_", 3272201433, "float", 280, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.tiltMax_", 1545518819, "float", 284, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.brakeAngleYaw_", 2147066825, "float", 288, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.brakePowerYaw_", 4043387, "float", 292, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.brakeAngleTilt_", 2129559783, "float", 296, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.brakePowerTilt_", 3270307801, "float", 300, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isUseDefaultAngleLimitTiltAtEventSeamless_", 3691097342, "bool", 304, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpAngleLimitTiltMin_", 2463471239, "float", 308, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpAngleLimitTiltMax_", 3957399925, "float", 312, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isSeamlessInterpCheckCollision_", 1525340344, "bool", 316, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_", 1212405091, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralStart", 320, 184, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.isUse_", 3844265519, "bool", 328, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.isCutChangeOrder_", 3253892828, "bool", 329, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.isNeedClearCameraContainerBlendDataWhenCutChange_", 2766568432, "bool", 330, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.interpTime_", 2531085065, "float", 332, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.interpBlendMode_", 2789238292, "SQEX.Ebony.Framework.TimeControl.InterpMode", 336, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.isUseCommonData_", 1517572076, "bool", 340, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.pogData_", 445348116, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart", 344, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.pogData_.isUse_", 888027134, "bool", 352, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.pogData_.isUpdateXEveryFrame_", 2931872526, "bool", 353, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.pogData_.isUpdateYEveryFrame__", 3344510108, "bool", 354, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.pogData_.isUpdateZEveryFrame_", 3794609352, "bool", 355, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.povData_", 3441519757, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart", 360, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.povData_.isUse_", 1737171005, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.povData_.isUpdateXEveryFrame_", 1813052373, "bool", 369, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.povData_.isUpdateYEveryFrame__", 3664942773, "bool", 370, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.povData_.isUpdateZEveryFrame_", 4268728619, "bool", 371, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnYawData_", 1125945992, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYawStart", 376, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnYawData_.rotationUseValueType_", 933979253, "Black.Camera.RotationUseValueType", 384, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnYawData_.rotationSetAngleType_", 3351655116, "Black.Camera.SeamlessInGameSetAngleType", 388, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnYawData_.rotationDirection_", 468837274, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 392, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnYawData_.isUse_", 3665933690, "bool", 400, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnYawData_.isUpdateTurnEveryFrame_", 3813035601, "bool", 401, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnTiltData_", 1381868460, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTiltStart", 408, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnTiltData_.rotationUseValueType_", 848138577, "Black.Camera.RotationUseValueType", 416, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnTiltData_.rotationSetAngleType_", 4120842280, "Black.Camera.SeamlessInGameSetAngleType", 420, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnTiltData_.rotationDirection_", 2244934246, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 424, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnTiltData_.isUse_", 1621257174, "bool", 432, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnTiltData_.isUpdateTurnEveryFrame_", 1696624221, "bool", 433, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnRollData_", 3698520960, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollStart", 440, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnRollData_.rotationUseValueType_", 419935757, "Black.Camera.RotationUseValueType", 448, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnRollData_.rotationSetAngleType_", 3057401812, "Black.Camera.SeamlessInGameSetAngleType", 452, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnRollData_.rotationDirection_", 2365738914, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 456, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnRollData_.isUse_", 2291587090, "bool", 464, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.turnRollData_.isUpdateTurnEveryFrame_", 3479856393, "bool", 465, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.fovData_", 2709739659, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovStartNew", 472, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.fovData_.isUse_", 901861559, "bool", 480, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.fovData_.fovUseValueType_", 812281835, "Black.Camera.FovUseValueType", 484, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.fovData_.setFovType_", 125308177, "Black.Camera.SeamlessInGameSetFovType", 488, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.startData_.fovData_.isUpdateEveryFrame_", 2744401015, "bool", 492, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_", 2740393908, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralEnd", 504, 208, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.isUse_", 595586846, "bool", 512, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.backToNormalIsCutChangeOrder_", 221142372, "bool", 513, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.backToNormalCoordInterpType_", 614861535, "Black.Camera.CoordInterpType", 516, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.backToNormalInterpTime_", 1891237873, "float", 520, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.backToNormalCameraTime1_", 1214481749, "float", 524, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.backToNormalCameraTime2_", 1214923034, "float", 528, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.backToNormalInterpBlendMode_", 579504972, "SQEX.Ebony.Framework.TimeControl.InterpMode", 532, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.isUseCommonData_", 2476604233, "bool", 536, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnYawData_", 3906441181, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYawEnd", 544, 48, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnYawData_.rotationUseValueType_", 4253496828, "Black.Camera.RotationUseValueType", 552, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnYawData_.rotationSetAngleType_", 4271246713, "Black.Camera.SeamlessInGameSetAngleType", 556, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnYawData_.rotationDirection_", 1558821025, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 560, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnYawData_.isUse_", 3379225773, "bool", 568, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnYawData_.interpMode_", 2600632205, "Black.Camera.BlendModeType", 572, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnYawData_.interpTime_", 4168035531, "float", 576, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnYawData_.interpVelocity_", 779499213, "float", 580, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnYawData_.turnYaw_", 38461346, "float", 584, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnTiltData_", 2334994875, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTiltEnd", 592, 48, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnTiltData_.rotationUseValueType_", 925850426, "Black.Camera.RotationUseValueType", 600, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnTiltData_.rotationSetAngleType_", 3685412563, "Black.Camera.SeamlessInGameSetAngleType", 604, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnTiltData_.rotationDirection_", 467599547, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 608, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnTiltData_.isUse_", 1808333447, "bool", 616, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnTiltData_.interpMode_", 1003387927, "Black.Camera.BlendModeType", 620, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnTiltData_.interpTime_", 2057041601, "float", 624, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnTiltData_.interpVelocity_", 2680253943, "float", 628, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnTiltData_.turnTilt_", 3007517132, "float", 632, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnRollData_", 3539229011, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollEnd", 640, 48, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnRollData_.rotationUseValueType_", 202461266, "Black.Camera.RotationUseValueType", 648, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnRollData_.rotationSetAngleType_", 2338518491, "Black.Camera.SeamlessInGameSetAngleType", 652, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnRollData_.rotationDirection_", 3594641475, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 656, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnRollData_.isUse_", 1170034303, "bool", 664, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnRollData_.interpMode_", 747586255, "Black.Camera.BlendModeType", 668, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnRollData_.interpTime_", 94273817, "float", 672, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnRollData_.interpVelocity_", 1178174927, "float", 676, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.turnRollData_.turnRoll_", 3505036552, "float", 680, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.fovData_", 1429330946, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovEnd", 688, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.fovData_.isChangeEndFov_", 4224987157, "bool", 696, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.fovData_.fovEndInterpMode_", 1740834506, "Black.Camera.BlendModeType", 700, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.fovData_.fovEndInterpTime_", 2775568156, "float", 704, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.endData_.fovData_.fovEndFInterpToSpeed_", 2931415573, "float", 708, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("lastViewKeepId_", 3613130477, "Ebony.Base.String", 128, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("generalData_", 3152804964, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralNew", 144, 568, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}