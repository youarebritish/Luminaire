using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class InGameCameraGeneralTrackItem : Black.System.TimeLine.TrackItem.BlendTrackItemBaseNoResource
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneral generalData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraGeneralTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.InGameCameraGeneralTrackItem", 0, Black.System.TimeLine.TrackItem.Camera.InGameCameraGeneralTrackItem.ObjectType, null, properties, 0, 328);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.InGameCameraGeneralTrackItem", base.GetFieldProperties(), 2003012440, -200681211);
            
			fieldProperties.AddIndirectlyProperty(new Property("name_", 182823483, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startTime_", 140908163, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("duration_", 1282328598, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blendRate_", 930283391, "float", 88, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startInterpTime_", 1816728177, "float", 92, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endInterpTime_", 654645938, "float", 96, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_", 1657928633, "SQEX.Ebony.Framework.TimeControl.CurveList", 104, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_.propertyList_", 3952472237, "SQEX.Ebony.Std.DynamicArray< AnchorReferenceValue* >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.filterLevel_", 2974887459, "Black.Camera.CameraFilterLevel", 136, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessGroupId_", 1391187118, "SQEX.Ebony.Std.Fixid", 140, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessId_", 2277146161, "Ebony.Base.String", 144, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.stopFilterType_", 2710847493, "Black.Camera.StopCameraFilterType", 160, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isEnableSwitchOtherCamera_", 3675368379, "bool", 164, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isEnableForceStopOtherCamera_", 3275571906, "bool", 165, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isEventSeamless_", 3391679914, "bool", 166, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpMode_", 1966776805, "Black.Camera.SeamlessInterpMode", 168, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneReleaseMode_", 3001437251, "Black.Camera.SeamlessInterpCloneReleaseMode", 172, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneAutoReleaseTime_", 2407461802, "float", 176, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_", 1504067211, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone", 184, 40, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToSeamlessCloneReleasePreset_", 1050619844, "Black.Camera.SeamlessCloneReleasePreset", 192, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalCoordInterpType_", 2920268546, "Black.Camera.CoordInterpType", 196, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalInterpTime_", 2875691494, "float", 200, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalCameraTime1_", 3447573160, "float", 204, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalCameraTime2_", 3447720255, "float", 208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalCameraAccel_", 1662314156, "float", 212, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessCloneData_.backToNormalInterpBlendMode_", 4064873013, "SQEX.Ebony.Framework.TimeControl.InterpMode", 216, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_", 3020087619, "Black.Camera.Struct.CameraControlTurn", 232, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.mode", 538119600, "Black.Camera.Struct.CameraControlTurnMode", 240, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.isUseAutoAdjustMode_", 3719792590, "bool", 244, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.isUseAutoAdjustAngleMode_", 1856784151, "bool", 245, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.isUseDefaultBrakeParam_", 4060082236, "bool", 246, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.controlTurnVelocity_", 2126948637, "float", 248, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.backToDefaultTurnVelocity_", 2575951811, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.yawMin_", 581279739, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.yawMax_", 2349539057, "float", 260, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.tiltMin_", 3272201433, "float", 264, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.tiltMax_", 1545518819, "float", 268, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.brakeAngleYaw_", 2147066825, "float", 272, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.brakePowerYaw_", 4043387, "float", 276, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.brakeAngleTilt_", 2129559783, "float", 280, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpCloneControlTurn_.brakePowerTilt_", 3270307801, "float", 284, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isUseDefaultAngleLimitTiltAtEventSeamless_", 3691097342, "bool", 288, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpAngleLimitTiltMin_", 2463471239, "float", 292, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.seamlessInterpAngleLimitTiltMax_", 3957399925, "float", 296, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isSeamlessInterpCheckCollision_", 1525340344, "bool", 300, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.backToNormalCameraTime1_", 1164211877, "float", 304, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.backToNormalCameraTime2_", 1164653162, "float", 308, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isBackToDefaultYaw_", 4198318621, "bool", 312, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.backToDefaultYawInterpSpeed_", 2011524630, "float", 316, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.isBackToDefaultTilt_", 238316035, "bool", 320, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("generalData_.backToDefaultTiltInterpSpeed_", 53164188, "float", 324, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("generalData_", 3152804964, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneral", 128, 200, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}