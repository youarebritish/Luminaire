using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionSeamlessInGameCameraBase : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin endPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cameraPin_;
		public Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItemNew seamlessParameter_;
		public bool isUseEndReserve_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSeamlessInGameCameraBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraBase", 0, Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraBase.ObjectType, null, properties, 0, 2400);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraBase", base.GetFieldProperties(), -877317690, 26446116);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPin_.pinName_", 3393751070, "Base.String", 184, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPin_.name_", 2709444057, "Base.String", 200, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPin_.connections_", 3972754729, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 216, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("startPin_.delayType_", 2098578323, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPin_.delayTime_", 2204508536, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startPin_.delayMaxTime_", 3635708722, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endPin_.pinName_", 1113190301, "Base.String", 280, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endPin_.name_", 853626984, "Base.String", 296, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endPin_.connections_", 2839725734, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 312, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("endPin_.delayType_", 1311405092, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endPin_.delayTime_", 1168370247, "float", 348, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endPin_.delayMaxTime_", 2168073055, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.pinName_", 1767361694, "Base.String", 376, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.name_", 2948420441, "Base.String", 392, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.connections_", 78281129, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 408, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.delayType_", 2315115539, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 440, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.delayTime_", 2421045752, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("outPin_.delayMaxTime_", 3973394610, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cameraPin_.pinName_", 1626967689, "Base.String", 472, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cameraPin_.name_", 1164034196, "Base.String", 488, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("cameraPin_.connections_", 3959604714, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 504, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("cameraPin_.pinValueType_", 1643032009, "Base.String", 536, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.name_", 143635512, "Ebony.Base.String", 568, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.startTime_", 1389430562, "float", 584, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.duration_", 3335034801, "float", 588, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_", 1701286086, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCommon", 648, 80, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.mode", 2872032779, "Black.Camera.InGameSeamlessTargetMode", 656, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.startEndBlendMode_", 2296457320, "Black.Camera.SeamlessInGameSeparateStartEndBlendMode", 660, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.isCheckCollision_", 942809165, "bool", 664, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_", 2594561413, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCollision", 672, 40, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.checkCollisionType_", 2792889382, "Black.Camera.CheckCollisionType", 680, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.isNeedCheckFocusFromPC_", 2798841865, "bool", 684, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.isNeedCheckAdjustPog_", 3388467487, "bool", 685, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.isNeedCheckGroundHeight_", 4290292920, "bool", 686, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.groundCheckMarginHeight_", 146133544, "float", 688, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.groundCheckMinimumHeight_", 1599813878, "float", 692, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.isEnableCharaFadeOutWhenCollidedByCamera_", 908932602, "bool", 696, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.isEnablePCFadeWhenCollidedByCamera_", 1852659678, "bool", 697, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.isUsePCFaseFadeWhenCollidedByCamera_", 1776344383, "bool", 698, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.isUseAdjustFadeMinPowerWhenCollidedByCamera_", 3408513961, "bool", 699, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.charaFadeByCameraSphereRadius_", 1243305420, "float", 700, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.isEndBlendCheckCollision_", 3297988018, "bool", 704, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.collisionData_.endBlendCheckCollisionType_", 3711186650, "Black.Camera.CheckCollisionType", 708, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.isEnableCancelWhenPCFrameOut_", 906349900, "bool", 712, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.isEnableCancelWhenTerribleCollieded_", 3354040688, "bool", 713, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.isCutChangeOrder", 3420593584, "bool", 714, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.isNeedClearCameraContainerBlendDataWhenCutChange_", 2201261977, "bool", 715, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.isUseBattleAssistRotationWhenNotControlingYaw_", 3951464314, "bool", 716, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.isIgnoreCameraShake_", 2769628122, "bool", 717, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.autoCompositionShotType_", 1997096704, "Black.Camera.AutoCompositionShotType", 720, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.commonData_.isNeedCaptureForOtherRelativeTarget_", 926124789, "bool", 724, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_", 3657424919, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPog", 736, 112, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.lockOnType_", 1088827230, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnType", 744, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.actorBaseType_", 2935401030, "Black.Camera.SeamlessInGameActorBaseType", 748, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.lockOnActorOffsetType_", 1291811366, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnActorOffsetType", 752, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.boneId_", 2115397993, "SQEX.Ebony.Std.Fixid", 756, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.coordInterpType_", 2914534915, "Black.Camera.CoordInterpType", 760, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.pogInterpTime_", 3456851449, "float", 764, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.pogTimeInterpMode_", 421817464, "SQEX.Ebony.Framework.TimeControl.InterpMode", 768, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.pogVelocity_", 381917901, "float", 772, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.isUpdateYDirectly_", 3372801004, "bool", 776, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.pogDirectionYVelocity_", 1323425817, "float", 780, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.matrixType_", 1999037059, "Black.Camera.MatrixType", 784, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.offsetType_", 4123060413, "Black.Camera.SeamlessInGameOffsetType", 788, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.pogOffset_", 3972890265, "Luminous.Math.VectorA", 800, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.isUseAddOffsetXByProjectionBetweenPCandTarget_", 2740515898, "bool", 832, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.addOffsetXSabunMultiplyRate_", 2052567523, "float", 836, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.addOffsetXMaxLimit_", 2444665243, "float", 840, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.isUpdateXEveryFrame_", 2946359575, "bool", 844, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.isUpdateYEveryFrame__", 2827992911, "bool", 845, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.pogData_.isUpdateZEveryFrame_", 1342903985, "bool", 846, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_", 1669805262, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov", 848, 128, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.lockOnType_", 1550986935, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnType", 856, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.actorBaseType_", 631887473, "Black.Camera.SeamlessInGameActorBaseType", 860, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.lockOnActorOffsetType_", 983732245, "Black.Sequence.Action.Camera.SequenceActionCameraLockTarget.LockOnActorOffsetType", 864, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.boneId_", 3234082500, "SQEX.Ebony.Std.Fixid", 868, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.autoCompositionBaseType_", 2168013303, "Black.Camera.AutoCompositionBaseType", 872, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.autoCompositionUpdateType_", 1182274819, "Black.Camera.AutoCompositionUpdateType", 876, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.valueSettingType_", 4080724064, "Black.Camera.ValueSettingType", 884, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.incEyeDistance_", 3766841731, "float", 888, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.isDisableBattleAddDistance_", 2659469503, "bool", 892, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.seamlessInGameFlameInAddDistanceCalcType_", 3629814140, "Black.Camera.SeamlessInGameFlameInAddDistanceCalcType", 896, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.isDisableAroundStatusAddDistance_", 2210501986, "bool", 900, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.addDistanceRate_", 447603299, "float", 904, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.isDisableAngleDiffBetweenCam2PCAddDistance_", 2917056727, "bool", 908, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.overrideEyeDistance_", 314524423, "float", 912, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.minimumGuaranteeEyeDistance_", 1596542917, "float", 916, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.povVelocity_", 882226539, "float", 920, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.matrixType_", 2555728298, "Black.Camera.MatrixType", 924, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.povOffset_", 1251250451, "Luminous.Math.VectorA", 928, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.offsetXValueType_", 2128689091, "Black.Camera.OffsetXValueType", 944, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.autoCompositionShotSize_", 1293013675, "int", 948, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.autoCompositionFovLevel_", 2338476185, "int", 952, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.autoCompositionPovBoneId_", 226836644, "SQEX.Ebony.Std.Fixid", 956, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.autoCompositionFlameHeightRate_", 2734151044, "float", 960, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.autoCompositionFlameHeightYawRate_", 3122897307, "float", 964, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.isUpdateXEveryFrame_", 857267672, "bool", 968, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.isUpdateYEveryFrame__", 684721486, "bool", 969, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.povData_.isUpdateZEveryFrame_", 2410808734, "bool", 970, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_", 3981981308, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurn", 976, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.isOverrideLockOnLayer_", 2728637830, "bool", 984, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.isUseLockOnTurn_", 3305961141, "bool", 985, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.isUseLockOnTurnTilt_", 3104790976, "bool", 986, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_", 16350813, "Black.Camera.Struct.CameraControlTurn", 992, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.mode", 2241179558, "Black.Camera.Struct.CameraControlTurnMode", 1000, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.isUseAutoAdjustMode_", 4138983180, "bool", 1004, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.isUseAutoAdjustAngleMode_", 837862769, "bool", 1005, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.isUseDefaultBrakeParam_", 2887207762, "bool", 1006, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.controlTurnVelocity_", 1500626139, "float", 1008, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.backToDefaultTurnVelocity_", 4070158945, "float", 1012, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.yawMin_", 2461927037, "float", 1016, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.yawMax_", 736524351, "float", 1020, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.tiltMin_", 2288094683, "float", 1024, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.tiltMax_", 4014777297, "float", 1028, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.brakeAngleYaw_", 967367535, "float", 1032, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.brakePowerYaw_", 3548532525, "float", 1036, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.brakeAngleTilt_", 3604515237, "float", 1040, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.controlTurn_.brakePowerTilt_", 2815647859, "float", 1044, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.angleLimit_", 3589486985, "Black.Camera.Struct.CameraAngleLimit", 1048, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.angleLimit_.tiltAngleLimitMode_", 4016915232, "Black.Camera.CameraAngleLimitMode", 1056, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.angleLimit_.tiltAngleLimitMin_", 3814280893, "float", 1060, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnData_.angleLimit_.tiltAngleLimitMax_", 2088878207, "float", 1064, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_", 1254386451, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYaw", 1072, 72, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.isUse_", 209838527, "bool", 1080, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.rotationUseValueTypeYaw_", 2220802697, "Black.Camera.RotationUseValueType", 1084, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.isNotControllingYawWhenBattleHybridAndOverride_", 3163149798, "bool", 1088, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.bestAngleJudgeType_", 3473295228, "Black.Camera.BestAngleJudgeType", 1092, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.turnInterpType_", 3604791567, "Black.Camera.RotationInterpType", 1096, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.turnTimeInterpMode_", 2829814513, "Black.Camera.BlendModeType", 1100, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.rotationDirection_", 3171316867, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 1104, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.isCalcAlwaysBehindPC_", 1328657347, "bool", 1108, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.isUpdateTurnEveryFrame_", 468757358, "bool", 1109, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.rotationSetAngleType_", 621053723, "Black.Camera.SeamlessInGameSetAngleType", 1112, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.turnInterpTimeYaw_", 271293147, "float", 1116, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.turnVelocityYaw_", 580031791, "float", 1120, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.turnYaw_", 3451926960, "float", 1124, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.isAllowUserControlTurn_", 1395532672, "bool", 1128, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.stealingPlayerDirectionInterpType_", 1844493211, "Black.Camera.StealingPlayerDirectionInterpType", 1132, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnYawData_.stealingPlayerDirectionInterpVelocity_", 3268184142, "float", 1136, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_", 1966882297, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTilt", 1144, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.isUse_", 1399101297, "bool", 1152, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.rotationUseValueTypeTilt_", 1188533621, "Black.Camera.RotationUseValueType", 1156, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.isUseDefaultValueWhenBattleHybridAndOverride_", 746469612, "bool", 1160, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.turnInterpType_", 783235733, "Black.Camera.RotationInterpType", 1164, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.turnTimeInterpMode_", 31494187, "Black.Camera.BlendModeType", 1168, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.isUseAdjustAngle_", 1437900447, "bool", 1176, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.isUpdateTurnEveryFrame_", 3106637632, "bool", 1177, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.rotationSetAngleType_", 2773092269, "Black.Camera.SeamlessInGameSetAngleType", 1180, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.turnInterpTimeTilt_", 2384118055, "float", 1184, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.turnVelocityTilt_", 2787646303, "float", 1188, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.turnTilt_", 152851434, "float", 1192, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.isAllowUserControlTurn_", 1914548910, "bool", 1196, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.stealingPlayerDirectionInterpType_", 3352276125, "Black.Camera.StealingPlayerDirectionInterpType", 1200, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnTiltData_.stealingPlayerDirectionInterpVelocity_", 2459623420, "float", 1204, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_", 3723209409, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRoll", 1208, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.isUse_", 489767833, "bool", 1216, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.rotationUseValueTypeRoll_", 3976896421, "Black.Camera.RotationUseValueType", 1220, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.turnInterpType_", 324610365, "Black.Camera.RotationInterpType", 1224, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.turnTimeInterpMode_", 1910173187, "Black.Camera.BlendModeType", 1228, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.isUpdateTurnEveryFrame_", 2516096168, "bool", 1236, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.rotationSetAngleType_", 3432797765, "Black.Camera.SeamlessInGameSetAngleType", 1240, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.turnInterpTimeRoll_", 456240183, "float", 1244, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.turnVelocityRoll_", 3415226015, "float", 1248, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.turnRoll_", 1877279190, "float", 1252, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.turnRollData_.isUseOldRollDirection_", 3205543256, "bool", 1256, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_", 818908889, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralNew", 1728, 568, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.filterLevel_", 1722513656, "Black.Camera.CameraFilterLevel", 1736, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessGroupId_", 1073132137, "SQEX.Ebony.Std.Fixid", 1740, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessId_", 2891551324, "Ebony.Base.String", 1744, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.stopFilterType_", 326070016, "Black.Camera.StopCameraFilterType", 1760, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.isEnableSwitchOtherCamera_", 1520171668, "bool", 1764, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.isEnableForceStopOtherCamera_", 2662356227, "bool", 1765, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.isEventSeamless_", 3019457697, "bool", 1766, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpMode_", 4129359928, "Black.Camera.SeamlessInterpMode", 1768, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneReleaseMode_", 2893761354, "Black.Camera.SeamlessInterpCloneReleaseMode", 1772, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneAutoReleaseTime_", 2195200287, "float", 1776, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessCloneData_", 3189536812, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone", 1784, 40, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessCloneData_.backToSeamlessCloneReleasePreset_", 3630837667, "Black.Camera.SeamlessCloneReleasePreset", 1792, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessCloneData_.backToNormalCoordInterpType_", 1047882295, "Black.Camera.CoordInterpType", 1796, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessCloneData_.backToNormalInterpTime_", 2201185129, "float", 1800, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessCloneData_.backToNormalCameraTime1_", 1477303789, "float", 1804, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessCloneData_.backToNormalCameraTime2_", 403977458, "float", 1808, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessCloneData_.backToNormalCameraAccel_", 3718135837, "float", 1812, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessCloneData_.backToNormalInterpBlendMode_", 2131477556, "SQEX.Ebony.Framework.TimeControl.InterpMode", 1816, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_", 1499393066, "Black.Camera.Struct.CameraControlTurn", 1832, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.mode", 728575983, "Black.Camera.Struct.CameraControlTurnMode", 1840, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.isUseAutoAdjustMode_", 1673448969, "bool", 1844, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.isUseAutoAdjustAngleMode_", 2521392802, "bool", 1845, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.isUseDefaultBrakeParam_", 1229840245, "bool", 1846, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.controlTurnVelocity_", 4198293558, "float", 1848, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.backToDefaultTurnVelocity_", 3631379416, "float", 1852, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.yawMin_", 391830010, "float", 1856, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.yawMax_", 3228634064, "float", 1860, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.tiltMin_", 3701477238, "float", 1864, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.tiltMax_", 900335460, "float", 1868, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.brakeAngleYaw_", 3949891186, "float", 1872, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.brakePowerYaw_", 3145525404, "float", 1876, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.brakeAngleTilt_", 2134293310, "float", 1880, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpCloneControlTurn_.brakePowerTilt_", 3498452648, "float", 1884, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.isUseDefaultAngleLimitTiltAtEventSeamless_", 3329976865, "bool", 1888, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpAngleLimitTiltMin_", 3065974668, "float", 1892, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.seamlessInterpAngleLimitTiltMax_", 2414339598, "float", 1896, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.isSeamlessInterpCheckCollision_", 241757729, "bool", 1900, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_", 3169723704, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralStart", 1904, 184, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.isUse_", 131795850, "bool", 1912, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.isCutChangeOrder_", 1021052775, "bool", 1913, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.isNeedClearCameraContainerBlendDataWhenCutChange_", 596603167, "bool", 1914, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.interpTime_", 4018432778, "float", 1916, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.interpBlendMode_", 649901321, "SQEX.Ebony.Framework.TimeControl.InterpMode", 1920, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.isUseCommonData_", 396617213, "bool", 1924, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.pogData_", 1867523833, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart", 1928, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.pogData_.isUse_", 161876593, "bool", 1936, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.pogData_.isUpdateXEveryFrame_", 2039771449, "bool", 1937, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.pogData_.isUpdateYEveryFrame__", 1048785033, "bool", 1938, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.pogData_.isUpdateZEveryFrame_", 1448409503, "bool", 1939, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.povData_", 1795103488, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart", 1944, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.povData_.isUse_", 3350434450, "bool", 1952, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.povData_.isUpdateXEveryFrame_", 3101275298, "bool", 1953, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.povData_.isUpdateYEveryFrame__", 510075888, "bool", 1954, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.povData_.isUpdateZEveryFrame_", 2503968924, "bool", 1955, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnYawData_", 2490227273, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYawStart", 1960, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnYawData_.rotationUseValueType_", 2941790352, "Black.Camera.RotationUseValueType", 1968, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnYawData_.rotationSetAngleType_", 4140486429, "Black.Camera.SeamlessInGameSetAngleType", 1972, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnYawData_.rotationDirection_", 3302262213, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 1976, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnYawData_.isUse_", 1960157921, "bool", 1984, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnYawData_.isUpdateTurnEveryFrame_", 2774752144, "bool", 1985, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnTiltData_", 415846927, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTiltStart", 1992, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnTiltData_.rotationUseValueType_", 2362652214, "Black.Camera.RotationUseValueType", 2000, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnTiltData_.rotationSetAngleType_", 3208465071, "Black.Camera.SeamlessInGameSetAngleType", 2004, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnTiltData_.rotationDirection_", 3818366983, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 2008, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnTiltData_.isUse_", 2295381187, "bool", 2016, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnTiltData_.isUpdateTurnEveryFrame_", 386522098, "bool", 2017, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnRollData_", 2692079399, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollStart", 2024, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnRollData_.rotationUseValueType_", 4211789294, "Black.Camera.RotationUseValueType", 2032, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnRollData_.rotationSetAngleType_", 29850359, "Black.Camera.SeamlessInGameSetAngleType", 2036, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnRollData_.rotationDirection_", 2202255055, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 2040, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnRollData_.isUse_", 1071192187, "bool", 2048, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.turnRollData_.isUpdateTurnEveryFrame_", 543252554, "bool", 2049, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.fovData_", 1271455014, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovStartNew", 2056, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.fovData_.isUse_", 809504548, "bool", 2064, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.fovData_.fovUseValueType_", 2097143724, "Black.Camera.FovUseValueType", 2068, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.fovData_.setFovType_", 523476628, "Black.Camera.SeamlessInGameSetFovType", 2072, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.startData_.fovData_.isUpdateEveryFrame_", 3155241894, "bool", 2076, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_", 1522757391, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralEnd", 2088, 208, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.isUse_", 3161926595, "bool", 2096, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.backToNormalIsCutChangeOrder_", 2552258791, "bool", 2097, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.backToNormalCoordInterpType_", 3483168590, "Black.Camera.CoordInterpType", 2100, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.backToNormalInterpTime_", 244904074, "float", 2104, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.backToNormalCameraTime1_", 551472508, "float", 2108, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.backToNormalCameraTime2_", 551619603, "float", 2112, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.backToNormalInterpBlendMode_", 2598692233, "SQEX.Ebony.Framework.TimeControl.InterpMode", 2116, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.isUseCommonData_", 2689072312, "bool", 2120, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnYawData_", 2041540300, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYawEnd", 2128, 48, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnYawData_.rotationUseValueType_", 2306937457, "Black.Camera.RotationUseValueType", 2136, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnYawData_.rotationSetAngleType_", 2040294728, "Black.Camera.SeamlessInGameSetAngleType", 2140, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnYawData_.rotationDirection_", 624265478, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 2144, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnYawData_.isUse_", 1793532662, "bool", 2152, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnYawData_.interpMode_", 905729096, "Black.Camera.BlendModeType", 2156, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnYawData_.interpTime_", 1808659566, "float", 2160, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnYawData_.interpVelocity_", 3516606208, "float", 2164, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnYawData_.turnYaw_", 1153254109, "float", 2168, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnTiltData_", 3842815608, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTiltEnd", 2176, 48, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnTiltData_.rotationUseValueType_", 1958352773, "Black.Camera.RotationUseValueType", 2184, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnTiltData_.rotationSetAngleType_", 1771896540, "Black.Camera.SeamlessInGameSetAngleType", 2188, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnTiltData_.rotationDirection_", 1381281770, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 2192, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnTiltData_.isUse_", 543015754, "bool", 2200, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnTiltData_.interpMode_", 820845116, "Black.Camera.BlendModeType", 2204, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnTiltData_.interpTime_", 3981622218, "float", 2208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnTiltData_.interpVelocity_", 2723528284, "float", 2212, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnTiltData_.turnTilt_", 3059360991, "float", 2216, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnRollData_", 3927164188, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollEnd", 2224, 48, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnRollData_.rotationUseValueType_", 775557921, "Black.Camera.RotationUseValueType", 2232, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnRollData_.rotationSetAngleType_", 3697147576, "Black.Camera.SeamlessInGameSetAngleType", 2236, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnRollData_.rotationDirection_", 3724616438, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 2240, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnRollData_.isUse_", 1691948710, "bool", 2248, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnRollData_.interpMode_", 569542424, "Black.Camera.BlendModeType", 2252, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnRollData_.interpTime_", 419135710, "float", 2256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnRollData_.interpVelocity_", 722338864, "float", 2260, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.turnRollData_.turnRoll_", 541994331, "float", 2264, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.fovData_", 3675387319, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovEnd", 2272, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.fovData_.isChangeEndFov_", 3704692380, "bool", 2280, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.fovData_.fovEndInterpMode_", 1264986591, "Black.Camera.BlendModeType", 2284, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.fovData_.fovEndInterpTime_", 1750517897, "float", 2288, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.generalData_.endData_.fovData_.fovEndFInterpToSpeed_", 164717452, "float", 2292, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_", 680421896, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovNew", 2296, 72, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.isUse_", 1209139194, "bool", 2304, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.fovCurveDegree_", 119523105, "float", 2308, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.fovUseValueType_", 2005694614, "Black.Camera.FovUseValueType", 2312, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.interpType_", 1916367021, "Black.Camera.RotationInterpType", 2316, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.timeInterpMode_", 2799597811, "Black.Camera.BlendModeType", 2320, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.setFovType_", 694911358, "Black.Camera.SeamlessInGameSetFovType", 2324, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.interpTime_", 2003211962, "float", 2328, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.interpVelocity_", 236331980, "float", 2332, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.autoCompositionOverrideFov_", 3097965413, "float", 2336, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.isUpdateEveryFrame_", 2836963700, "bool", 2340, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.isKeepFovFromLastSeamlessCamera_", 4275015779, "bool", 2341, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.isIgnoreIncrementFov_", 1825602713, "bool", 2342, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.useCalculateFov_", 582049795, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovNew.CalculateFOVType", 2344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.maxTargetRaidus_", 537924638, "float", 2348, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.minTargetRaidus_", 3675811952, "float", 2352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessParameter_.fovData_.boundingSizeRate_", 3480567374, "float", 2356, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("startPin_", 2664043275, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endPin_", 1225342026, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPin_", 2732252299, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraPin_", 1695617774, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessParameter_", 2917807098, "Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItemNew", 560, 1808, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseEndReserve_", 1132012408, "bool", 2368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}