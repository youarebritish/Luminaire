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

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class InGameCameraGeneralNew : Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		[UnityEngine.SerializeReference] public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralStart startData_= new Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralStart();
		[UnityEngine.SerializeReference] public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralEnd endData_= new Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralEnd();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraGeneralNew();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralNew", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralNew.ObjectType, Construct, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralNew", base.GetFieldProperties(), 1199235667, 1048778738);
            
			fieldProperties.AddIndirectlyProperty(new Property("filterLevel_", 124193320, "Black.Camera.CameraFilterLevel", 8, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessGroupId_", 119581881, "SQEX.Ebony.Std.Fixid", 12, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessId_", 845162028, "Ebony.Base.String", 16, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("stopFilterType_", 3896259952, "Black.Camera.StopCameraFilterType", 32, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isEnableSwitchOtherCamera_", 2148770948, "bool", 36, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isEnableForceStopOtherCamera_", 4053675315, "bool", 37, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isEventSeamless_", 891408881, "bool", 38, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpMode_", 2284664936, "Black.Camera.SeamlessInterpMode", 40, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneReleaseMode_", 4190490874, "Black.Camera.SeamlessInterpCloneReleaseMode", 44, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneAutoReleaseTime_", 2087610095, "float", 48, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessCloneData_", 2316245948, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone", 56, 40, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessCloneData_.backToSeamlessCloneReleasePreset_", 3120552147, "Black.Camera.SeamlessCloneReleasePreset", 64, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessCloneData_.backToNormalCoordInterpType_", 3403636263, "Black.Camera.CoordInterpType", 68, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessCloneData_.backToNormalInterpTime_", 4144128153, "float", 72, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessCloneData_.backToNormalCameraTime1_", 3160556957, "float", 76, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessCloneData_.backToNormalCameraTime2_", 3161101410, "float", 80, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessCloneData_.backToNormalCameraAccel_", 3622663437, "float", 84, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessCloneData_.backToNormalInterpBlendMode_", 2898852708, "SQEX.Ebony.Framework.TimeControl.InterpMode", 88, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_", 1610712634, "Black.Camera.Struct.CameraControlTurn", 104, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.mode", 2681368415, "Black.Camera.Struct.CameraControlTurnMode", 112, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.isUseAutoAdjustMode_", 611056217, "bool", 116, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.isUseAutoAdjustAngleMode_", 605917074, "bool", 117, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.isUseDefaultBrakeParam_", 548349285, "bool", 118, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.controlTurnVelocity_", 704547078, "float", 120, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.backToDefaultTurnVelocity_", 751408456, "float", 124, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.yawMin_", 2430385706, "float", 128, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.yawMax_", 4157068320, "float", 132, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.tiltMin_", 476074694, "float", 136, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.tiltMax_", 1933546388, "float", 140, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.brakeAngleYaw_", 2349836770, "float", 144, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.brakePowerYaw_", 3596967148, "float", 148, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.brakeAngleTilt_", 2040184334, "float", 152, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.brakePowerTilt_", 4278192792, "float", 156, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("isUseDefaultAngleLimitTiltAtEventSeamless_", 3153703281, "bool", 160, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpAngleLimitTiltMin_", 3922170044, "float", 164, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpAngleLimitTiltMax_", 3275654686, "float", 168, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isSeamlessInterpCheckCollision_", 3021459793, "bool", 172, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.isUse_", 1079566106, "bool", 184, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.isCutChangeOrder_", 1399523543, "bool", 185, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.isNeedClearCameraContainerBlendDataWhenCutChange_", 829374735, "bool", 186, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.interpTime_", 975778778, "float", 188, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.interpBlendMode_", 3676162521, "SQEX.Ebony.Framework.TimeControl.InterpMode", 192, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.isUseCommonData_", 3355257965, "bool", 196, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.pogData_", 2839328041, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart", 200, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.pogData_.isUse_", 931822913, "bool", 208, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.pogData_.isUpdateXEveryFrame_", 2632515657, "bool", 209, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.pogData_.isUpdateYEveryFrame__", 3918269913, "bool", 210, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.pogData_.isUpdateZEveryFrame_", 3538525231, "bool", 211, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.povData_", 2447143568, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart", 216, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.povData_.isUse_", 3762518210, "bool", 224, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.povData_.isUpdateXEveryFrame_", 546611090, "bool", 225, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.povData_.isUpdateYEveryFrame__", 2615711328, "bool", 226, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.povData_.isUpdateZEveryFrame_", 1512709260, "bool", 227, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnYawData_", 2475609209, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYawStart", 232, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnYawData_.rotationUseValueType_", 2174567840, "Black.Camera.RotationUseValueType", 240, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnYawData_.rotationSetAngleType_", 3138372141, "Black.Camera.SeamlessInGameSetAngleType", 244, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnYawData_.rotationDirection_", 63992789, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 248, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnYawData_.isUse_", 168578801, "bool", 256, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnYawData_.isUpdateTurnEveryFrame_", 1462109632, "bool", 257, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnTiltData_", 4201520031, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTiltStart", 264, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnTiltData_.rotationUseValueType_", 564813670, "Black.Camera.RotationUseValueType", 272, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnTiltData_.rotationSetAngleType_", 3535053791, "Black.Camera.SeamlessInGameSetAngleType", 276, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnTiltData_.rotationDirection_", 2548442871, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 280, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnTiltData_.isUse_", 3481862131, "bool", 288, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnTiltData_.isUpdateTurnEveryFrame_", 1312376450, "bool", 289, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnRollData_", 2588371351, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollStart", 296, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnRollData_.rotationUseValueType_", 2537070398, "Black.Camera.RotationUseValueType", 304, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnRollData_.rotationSetAngleType_", 1257328135, "Black.Camera.SeamlessInGameSetAngleType", 308, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnRollData_.rotationDirection_", 2843296479, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 312, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnRollData_.isUse_", 371850891, "bool", 320, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.turnRollData_.isUpdateTurnEveryFrame_", 3096792698, "bool", 321, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.fovData_", 3926117654, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovStartNew", 328, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.fovData_.isUse_", 2949628660, "bool", 336, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.fovData_.fovUseValueType_", 3785356316, "Black.Camera.FovUseValueType", 340, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.fovData_.setFovType_", 1490594916, "Black.Camera.SeamlessInGameSetFovType", 344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startData_.fovData_.isUpdateEveryFrame_", 3795741878, "bool", 348, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.isUse_", 1756500179, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.backToNormalIsCutChangeOrder_", 224919575, "bool", 369, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.backToNormalCoordInterpType_", 410524830, "Black.Camera.CoordInterpType", 372, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.backToNormalInterpTime_", 1386321434, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.backToNormalCameraTime1_", 2403523020, "float", 380, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.backToNormalCameraTime2_", 3477437731, "float", 384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.backToNormalInterpBlendMode_", 1209090073, "SQEX.Ebony.Framework.TimeControl.InterpMode", 388, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.isUseCommonData_", 1585474920, "bool", 392, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnYawData_", 1849977596, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYawEnd", 400, 48, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnYawData_.rotationUseValueType_", 3772847361, "Black.Camera.RotationUseValueType", 408, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnYawData_.rotationSetAngleType_", 2355272216, "Black.Camera.SeamlessInGameSetAngleType", 412, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnYawData_.rotationDirection_", 1119644246, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 416, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnYawData_.isUse_", 3993846278, "bool", 424, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnYawData_.interpMode_", 3198300792, "Black.Camera.BlendModeType", 428, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnYawData_.interpTime_", 199604926, "float", 432, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnYawData_.interpVelocity_", 2625357712, "float", 436, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnYawData_.turnYaw_", 3259349229, "float", 440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnTiltData_", 154728456, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTiltEnd", 448, 48, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnTiltData_.rotationUseValueType_", 3988389365, "Black.Camera.RotationUseValueType", 456, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnTiltData_.rotationSetAngleType_", 2111097932, "Black.Camera.SeamlessInGameSetAngleType", 460, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnTiltData_.rotationDirection_", 4177805338, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 464, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnTiltData_.isUse_", 5454330, "bool", 472, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnTiltData_.interpMode_", 3374297228, "Black.Camera.BlendModeType", 476, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnTiltData_.interpTime_", 3190539450, "float", 480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnTiltData_.interpVelocity_", 796930508, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnTiltData_.turnTilt_", 617002479, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnRollData_", 1047873228, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollEnd", 496, 48, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnRollData_.rotationUseValueType_", 1095641713, "Black.Camera.RotationUseValueType", 504, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnRollData_.rotationSetAngleType_", 828998984, "Black.Camera.SeamlessInGameSetAngleType", 508, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnRollData_.rotationDirection_", 3914715398, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 512, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnRollData_.isUse_", 713157366, "bool", 520, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnRollData_.interpMode_", 2388307016, "Black.Camera.BlendModeType", 524, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnRollData_.interpTime_", 3291237486, "float", 528, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnRollData_.interpVelocity_", 126287616, "float", 532, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.turnRollData_.turnRoll_", 328319659, "float", 536, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.fovData_", 3856964263, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovEnd", 544, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.fovData_.isChangeEndFov_", 2158186220, "bool", 552, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.fovData_.fovEndInterpMode_", 2471308015, "Black.Camera.BlendModeType", 556, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.fovData_.fovEndInterpTime_", 95020985, "float", 560, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endData_.fovData_.fovEndFInterpToSpeed_", 3076053052, "float", 564, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("startData_", 2680278824, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralStart", 176, 184, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endData_", 1827778047, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralEnd", 360, 208, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new InGameCameraGeneralNew();
        }
		
    }
}