using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class CameraCCFTrackItem : Black.System.TimeLine.TrackItem.BlendTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string sourcePath_;
		public float totalBaseFrame_;
		public bool isLoop_;
		public float speed_;
		public float startFrame_;
		public float endFrame_;
		public bool isEventSeamless_;
		public bool isInGameStateWhenSeamlessOut_;
		public int seamlessInterpMode_;
		public int seamlessInterpCloneReleaseMode_;
		public float seamlessInterpCloneAutoReleaseTime_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone seamlessCloneData_;
		public Black.Camera.Struct.CameraControlTurn seamlessInterpCloneControlTurn_;
		public bool isUseDefaultAngleLimitTiltAtEventSeamless_;
		public float seamlessInterpAngleLimitTiltMin_;
		public float seamlessInterpAngleLimitTiltMax_;
		public bool isSeamlessInterpCheckCollision_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CameraCCFTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.CameraCCFTrackItem", 0, Black.System.TimeLine.TrackItem.CameraCCFTrackItem.ObjectType, null, properties, 0, 344);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.CameraCCFTrackItem", base.GetFieldProperties(), -2039134296, -1030576884);
            
			fieldProperties.AddIndirectlyProperty(new Property("name_", 182823483, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startTime_", 140908163, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("duration_", 1282328598, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blendRate_", 930283391, "float", 136, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startInterpTime_", 1816728177, "float", 140, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("endInterpTime_", 654645938, "float", 144, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_", 1657928633, "SQEX.Ebony.Framework.TimeControl.CurveList", 152, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_.propertyList_", 3952472237, "SQEX.Ebony.Std.DynamicArray< AnchorReferenceValue* >", 160, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessCloneData_.backToSeamlessCloneReleasePreset_", 3120552147, "Black.Camera.SeamlessCloneReleasePreset", 240, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessCloneData_.backToNormalCoordInterpType_", 3403636263, "Black.Camera.CoordInterpType", 244, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessCloneData_.backToNormalInterpTime_", 4144128153, "float", 248, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessCloneData_.backToNormalCameraTime1_", 3160556957, "float", 252, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessCloneData_.backToNormalCameraTime2_", 3161101410, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessCloneData_.backToNormalCameraAccel_", 3622663437, "float", 260, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessCloneData_.backToNormalInterpBlendMode_", 2898852708, "SQEX.Ebony.Framework.TimeControl.InterpMode", 264, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.mode", 2681368415, "Black.Camera.Struct.CameraControlTurnMode", 280, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.isUseAutoAdjustMode_", 611056217, "bool", 284, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.isUseAutoAdjustAngleMode_", 605917074, "bool", 285, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.isUseDefaultBrakeParam_", 548349285, "bool", 286, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.controlTurnVelocity_", 704547078, "float", 288, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.backToDefaultTurnVelocity_", 751408456, "float", 292, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.yawMin_", 2430385706, "float", 296, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.yawMax_", 4157068320, "float", 300, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.tiltMin_", 476074694, "float", 304, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.tiltMax_", 1933546388, "float", 308, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.brakeAngleYaw_", 2349836770, "float", 312, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.brakePowerYaw_", 3596967148, "float", 316, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.brakeAngleTilt_", 2040184334, "float", 320, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("seamlessInterpCloneControlTurn_.brakePowerTilt_", 4278192792, "float", 324, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			
			
			fieldProperties.AddProperty(new Property("sourcePath_", 341055184, "Ebony.Base.String", 176, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("totalBaseFrame_", 296522182, "float", 192, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isLoop_", 2814623788, "bool", 196, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("speed_", 1253745677, "float", 200, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("startFrame_", 4140515073, "float", 204, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("endFrame_", 616391468, "float", 208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEventSeamless_", 891408881, "bool", 212, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isInGameStateWhenSeamlessOut_", 1465141247, "bool", 213, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessInterpMode_", 2284664936, "Black.Camera.SeamlessInterpMode", 216, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessInterpCloneReleaseMode_", 4190490874, "Black.Camera.SeamlessInterpCloneReleaseMode", 220, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessInterpCloneAutoReleaseTime_", 2087610095, "float", 224, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessCloneData_", 2316245948, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone", 232, 40, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessInterpCloneControlTurn_", 1610712634, "Black.Camera.Struct.CameraControlTurn", 272, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseDefaultAngleLimitTiltAtEventSeamless_", 3153703281, "bool", 328, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessInterpAngleLimitTiltMin_", 3922170044, "float", 332, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessInterpAngleLimitTiltMax_", 3275654686, "float", 336, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isSeamlessInterpCheckCollision_", 3021459793, "bool", 340, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}