using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class InGameCameraTrackItem : Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneral generalData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFov fovData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItem", 0, Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItem.ObjectType, null, properties, 0, 1504);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItem", base.GetFieldProperties(), -209185905, 2050174665);
            
			fieldProperties.AddIndirectlyProperty(new Property("name_", 182823483, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startTime_", 140908163, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("duration_", 1282328598, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_", 2069969881, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCommon", 88, 80, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.mode", 1852175906, "Black.Camera.InGameSeamlessTargetMode", 96, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.startEndBlendMode_", 3000916853, "Black.Camera.SeamlessInGameSeparateStartEndBlendMode", 100, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.isCheckCollision_", 2397548114, "bool", 104, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_", 1305617768, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCollision", 112, 40, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.checkCollisionType_", 88331415, "Black.Camera.CheckCollisionType", 120, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.isNeedCheckFocusFromPC_", 2725639260, "bool", 124, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.isNeedCheckAdjustPog_", 2687050262, "bool", 125, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.isNeedCheckGroundHeight_", 998449139, "bool", 126, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.groundCheckMarginHeight_", 1554342835, "float", 128, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.groundCheckMinimumHeight_", 4026439387, "float", 132, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.isEnableCharaFadeOutWhenCollidedByCamera_", 2970294967, "bool", 136, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.isEnablePCFadeWhenCollidedByCamera_", 3352589291, "bool", 137, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.isUsePCFaseFadeWhenCollidedByCamera_", 109148000, "bool", 138, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.isUseAdjustFadeMinPowerWhenCollidedByCamera_", 2184529942, "bool", 139, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.charaFadeByCameraSphereRadius_", 2541676283, "float", 140, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.isEndBlendCheckCollision_", 302127735, "bool", 144, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.collisionData_.endBlendCheckCollisionType_", 3824355899, "Black.Camera.CheckCollisionType", 148, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.isEnableCancelWhenPCFrameOut_", 2497537047, "bool", 152, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.isEnableCancelWhenTerribleCollieded_", 3186678865, "bool", 153, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.isCutChangeOrder", 3983111193, "bool", 154, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.isNeedClearCameraContainerBlendDataWhenCutChange_", 3956054690, "bool", 155, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.isUseBattleAssistRotationWhenNotControlingYaw_", 3599718539, "bool", 156, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.isIgnoreCameraShake_", 3591993503, "bool", 157, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.autoCompositionShotType_", 1776257369, "Black.Camera.AutoCompositionShotType", 160, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("commonData_.isNeedCaptureForOtherRelativeTarget_", 732736696, "bool", 164, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_", 3340733518, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPog", 176, 112, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.lockOnType_", 1826811447, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnType", 184, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.actorBaseType_", 3650646257, "Black.Camera.SeamlessInGameActorBaseType", 188, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.lockOnActorOffsetType_", 37354133, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnActorOffsetType", 192, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.boneId_", 3344954948, "SQEX.Ebony.Std.Fixid", 196, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.coordInterpType_", 610425448, "Black.Camera.CoordInterpType", 200, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.pogInterpTime_", 2007061990, "float", 204, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.pogTimeInterpMode_", 2045120351, "SQEX.Ebony.Framework.TimeControl.InterpMode", 208, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.pogVelocity_", 35893654, "float", 212, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.isUpdateYDirectly_", 2837987103, "bool", 216, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.pogDirectionYVelocity_", 1082124262, "float", 220, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.matrixType_", 2831552810, "Black.Camera.MatrixType", 224, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.offsetType_", 3965516812, "Black.Camera.SeamlessInGameOffsetType", 228, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.pogOffset_", 607576642, "Luminous.Math.VectorA", 240, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.isUseAddOffsetXByProjectionBetweenPCandTarget_", 2569193589, "bool", 272, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.addOffsetXSabunMultiplyRate_", 2477256568, "float", 276, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.addOffsetXMaxLimit_", 1754952542, "float", 280, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.isUpdateXEveryFrame_", 3116278872, "bool", 284, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.isUpdateYEveryFrame__", 2680651982, "bool", 285, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pogData_.isUpdateZEveryFrame_", 374852638, "bool", 286, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_", 1033385879, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov", 288, 128, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.lockOnType_", 1364651742, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnType", 296, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.actorBaseType_", 1659192518, "Black.Camera.SeamlessInGameActorBaseType", 300, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.lockOnActorOffsetType_", 345433254, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnActorOffsetType", 304, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.boneId_", 2226270441, "SQEX.Ebony.Std.Fixid", 308, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionBaseType_", 3587113400, "Black.Camera.AutoCompositionBaseType", 312, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionUpdateType_", 3636045284, "Black.Camera.AutoCompositionUpdateType", 316, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.valueSettingType_", 3899692185, "Black.Camera.ValueSettingType", 324, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.incEyeDistance_", 3329328574, "float", 328, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isDisableBattleAddDistance_", 3133886870, "bool", 332, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.seamlessInGameFlameInAddDistanceCalcType_", 3621477053, "Black.Camera.SeamlessInGameFlameInAddDistanceCalcType", 336, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isDisableAroundStatusAddDistance_", 2636424483, "bool", 340, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.addDistanceRate_", 1951347064, "float", 344, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isDisableAngleDiffBetweenCam2PCAddDistance_", 3966181618, "bool", 348, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.overrideEyeDistance_", 2086105640, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.minimumGuaranteeEyeDistance_", 4222704638, "float", 356, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.povVelocity_", 4121629536, "float", 360, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.matrixType_", 2274861571, "Black.Camera.MatrixType", 364, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.povOffset_", 1648594688, "Luminous.Math.VectorA", 368, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.offsetXValueType_", 149451218, "Black.Camera.OffsetXValueType", 384, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionShotSize_", 1942688948, "int", 388, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionFovLevel_", 4171386142, "int", 392, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionPovBoneId_", 4019793381, "SQEX.Ebony.Std.Fixid", 396, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionFlameHeightRate_", 2925817925, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.autoCompositionFlameHeightYawRate_", 7214720, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isUpdateXEveryFrame_", 910403479, "bool", 408, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isUpdateYEveryFrame__", 528956111, "bool", 409, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("povData_.isUpdateZEveryFrame_", 3601915185, "bool", 410, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_", 3671100655, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurn", 416, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.isOverrideLockOnLayer_", 3567920311, "bool", 424, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.isUseLockOnTurn_", 2533559228, "bool", 425, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.isUseLockOnTurnTilt_", 2859245817, "bool", 426, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.controlTurn_", 1988401852, "Black.Camera.Struct.CameraControlTurn", 432, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.controlTurn_.mode", 4087316061, "Black.Camera.Struct.CameraControlTurnMode", 440, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.controlTurn_.isUseAutoAdjustMode_", 2245401815, "bool", 444, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.controlTurn_.isUseAutoAdjustAngleMode_", 1072408860, "bool", 445, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.controlTurn_.isUseDefaultBrakeParam_", 2797317379, "bool", 446, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.controlTurn_.controlTurnVelocity_", 2767405268, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.controlTurn_.backToDefaultTurnVelocity_", 775007214, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.controlTurn_.yawMin_", 3403517188, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.controlTurn_.yawMax_", 4057123734, "float", 460, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.controlTurn_.tiltMin_", 1427567976, "float", 464, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.controlTurn_.tiltMax_", 2116248418, "float", 468, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.controlTurn_.brakeAngleYaw_", 124100920, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.controlTurn_.brakePowerYaw_", 345049326, "float", 476, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.controlTurn_.brakeAngleTilt_", 249626076, "float", 480, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.controlTurn_.brakePowerTilt_", 812313170, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.angleLimit_", 1759721162, "Black.Camera.Struct.CameraAngleLimit", 488, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.angleLimit_.tiltAngleLimitMode_", 3197147083, "Black.Camera.CameraAngleLimitMode", 496, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.angleLimit_.tiltAngleLimitMin_", 4287928484, "float", 500, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnData_.angleLimit_.tiltAngleLimitMax_", 2835576502, "float", 504, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_", 1189308438, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYaw", 512, 72, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.isUse_", 2445327348, "bool", 520, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.rotationUseValueTypeYaw_", 22325730, "Black.Camera.RotationUseValueType", 524, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.isNotControllingYawWhenBattleHybridAndOverride_", 515634707, "bool", 528, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.bestAngleJudgeType_", 2113379217, "Black.Camera.BestAngleJudgeType", 532, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.turnInterpType_", 1581744190, "Black.Camera.RotationInterpType", 536, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.turnTimeInterpMode_", 999402040, "Black.Camera.BlendModeType", 540, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.rotationDirection_", 1579384420, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 544, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.isCalcAlwaysBehindPC_", 218596610, "bool", 548, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.isUpdateTurnEveryFrame_", 2860236819, "bool", 549, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.rotationSetAngleType_", 4027057550, "Black.Camera.SeamlessInGameSetAngleType", 552, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.turnInterpTimeYaw_", 3415929816, "float", 556, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.turnVelocityYaw_", 3429335724, "float", 560, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.turnYaw_", 3407041383, "float", 564, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.isAllowUserControlTurn_", 1386884045, "bool", 568, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.stealingPlayerDirectionInterpType_", 3872775816, "Black.Camera.StealingPlayerDirectionInterpType", 572, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnYawData_.stealingPlayerDirectionInterpVelocity_", 2107978821, "float", 576, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_", 79670634, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTilt", 584, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.isUse_", 2992710000, "bool", 592, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.rotationUseValueTypeTilt_", 3715975330, "Black.Camera.RotationUseValueType", 596, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.isUseDefaultValueWhenBattleHybridAndOverride_", 4241513211, "bool", 600, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.turnInterpType_", 903898274, "Black.Camera.RotationInterpType", 604, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.turnTimeInterpMode_", 832028964, "Black.Camera.BlendModeType", 608, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.isUseAdjustAngle_", 1146449860, "bool", 616, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.isUpdateTurnEveryFrame_", 1074158991, "bool", 617, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.rotationSetAngleType_", 1435317018, "Black.Camera.SeamlessInGameSetAngleType", 620, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.turnInterpTimeTilt_", 4252847792, "float", 624, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.turnVelocityTilt_", 26693988, "float", 628, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.turnTilt_", 2801002817, "float", 632, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.isAllowUserControlTurn_", 2421530481, "bool", 636, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.stealingPlayerDirectionInterpType_", 401852092, "Black.Camera.StealingPlayerDirectionInterpType", 640, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnTiltData_.stealingPlayerDirectionInterpVelocity_", 1254507521, "float", 644, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnRollData_", 1042086494, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRoll", 648, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnRollData_.isUse_", 2054150972, "bool", 656, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnRollData_.rotationUseValueTypeRoll_", 24029658, "Black.Camera.RotationUseValueType", 660, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnRollData_.turnInterpType_", 2204224454, "Black.Camera.RotationInterpType", 664, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnRollData_.turnTimeInterpMode_", 3249320848, "Black.Camera.BlendModeType", 668, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnRollData_.isUpdateTurnEveryFrame_", 3180718299, "bool", 676, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnRollData_.rotationSetAngleType_", 2420528358, "Black.Camera.SeamlessInGameSetAngleType", 680, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnRollData_.turnInterpTimeRoll_", 1237931272, "float", 684, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turnRollData_.turnVelocityRoll_", 1970345972, "float", 688, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnRollData_.turnRoll_", 1452588461, "float", 692, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("turnRollData_.isUseOldRollDirection_", 2950445589, "bool", 696, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.filterLevel_", 2974887459, "Black.Camera.CameraFilterLevel", 1176, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessGroupId_", 1391187118, "SQEX.Ebony.Std.Fixid", 1180, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessId_", 2277146161, "Ebony.Base.String", 1184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.stopFilterType_", 2710847493, "Black.Camera.StopCameraFilterType", 1200, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isEnableSwitchOtherCamera_", 3675368379, "bool", 1204, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isEnableForceStopOtherCamera_", 3275571906, "bool", 1205, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isEventSeamless_", 3391679914, "bool", 1206, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpMode_", 1966776805, "Black.Camera.SeamlessInterpMode", 1208, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneReleaseMode_", 3001437251, "Black.Camera.SeamlessInterpCloneReleaseMode", 1212, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneAutoReleaseTime_", 2407461802, "float", 1216, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_", 1504067211, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone", 1224, 40, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToSeamlessCloneReleasePreset_", 1050619844, "Black.Camera.SeamlessCloneReleasePreset", 1232, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalCoordInterpType_", 2920268546, "Black.Camera.CoordInterpType", 1236, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalInterpTime_", 2875691494, "float", 1240, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalCameraTime1_", 3447573160, "float", 1244, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalCameraTime2_", 3447720255, "float", 1248, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalCameraAccel_", 1662314156, "float", 1252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalInterpBlendMode_", 4064873013, "SQEX.Ebony.Framework.TimeControl.InterpMode", 1256, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_", 3020087619, "Black.Camera.Struct.CameraControlTurn", 1272, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.mode", 538119600, "Black.Camera.Struct.CameraControlTurnMode", 1280, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.isUseAutoAdjustMode_", 3719792590, "bool", 1284, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.isUseAutoAdjustAngleMode_", 1856784151, "bool", 1285, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.isUseDefaultBrakeParam_", 4060082236, "bool", 1286, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.controlTurnVelocity_", 2126948637, "float", 1288, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.backToDefaultTurnVelocity_", 2575951811, "float", 1292, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.yawMin_", 581279739, "float", 1296, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.yawMax_", 2349539057, "float", 1300, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.tiltMin_", 3272201433, "float", 1304, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.tiltMax_", 1545518819, "float", 1308, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.brakeAngleYaw_", 2147066825, "float", 1312, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.brakePowerYaw_", 4043387, "float", 1316, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.brakeAngleTilt_", 2129559783, "float", 1320, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.brakePowerTilt_", 3270307801, "float", 1324, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isUseDefaultAngleLimitTiltAtEventSeamless_", 3691097342, "bool", 1328, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpAngleLimitTiltMin_", 2463471239, "float", 1332, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpAngleLimitTiltMax_", 3957399925, "float", 1336, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isSeamlessInterpCheckCollision_", 1525340344, "bool", 1340, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.backToNormalCameraTime1_", 1164211877, "float", 1344, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.backToNormalCameraTime2_", 1164653162, "float", 1348, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isBackToDefaultYaw_", 4198318621, "bool", 1352, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.backToDefaultYawInterpSpeed_", 2011524630, "float", 1356, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isBackToDefaultTilt_", 238316035, "bool", 1360, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.backToDefaultTiltInterpSpeed_", 53164188, "float", 1364, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.isUse_", 4252696761, "bool", 1376, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.fovCurveDegree_", 1511594452, "float", 1380, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.fovUseValueType_", 3709996473, "Black.Camera.FovUseValueType", 1384, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.interpType_", 2625157596, "Black.Camera.RotationInterpType", 1388, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.timeInterpMode_", 2279307602, "Black.Camera.BlendModeType", 1392, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.setFovType_", 2031959359, "Black.Camera.SeamlessInGameSetFovType", 1396, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.interpTime_", 3777021775, "float", 1400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.interpVelocity_", 386526241, "float", 1404, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.autoCompositionOverrideFov_", 3185339512, "float", 1408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.isUpdateEveryFrame_", 477637569, "bool", 1412, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.isKeepFovFromLastSeamlessCamera_", 905858788, "bool", 1413, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.isIgnoreIncrementFov_", 4109359260, "bool", 1414, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.useCalculateFov_", 394518596, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovNew.CalculateFOVType", 1416, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.maxTargetRaidus_", 3540973189, "float", 1420, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.minTargetRaidus_", 1968280059, "float", 1424, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.boundingSizeRate_", 1937741635, "float", 1428, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.startData_", 424214896, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovStart", 1440, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.startData_.isChangeStartFov_", 749153606, "bool", 1448, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.startData_.fovStartInterpMode_", 855981111, "Black.Camera.BlendModeType", 1452, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.startData_.fovStartInterpTime_", 887310945, "float", 1456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.startData_.fovStartFInterpToSpeed_", 1320334068, "float", 1460, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.startData_.fovStartDegree_", 577660132, "float", 1464, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.endData_", 1130584631, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovEnd", 1472, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.endData_.isChangeEndFov_", 1745134364, "bool", 1480, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.endData_.fovEndInterpMode_", 4188832351, "Black.Camera.BlendModeType", 1484, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.endData_.fovEndInterpTime_", 379396361, "float", 1488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fovData_.endData_.fovEndFInterpToSpeed_", 574931980, "float", 1492, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("generalData_", 3152804964, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneral", 1168, 200, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fovData_", 3792695137, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFov", 1368, 128, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}