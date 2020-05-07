using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraGeneralBase : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int filterLevel_;
		public uint seamlessGroupId_;
		public string seamlessId_;
		public int stopFilterType_;
		public bool isEnableSwitchOtherCamera_;
		public bool isEnableForceStopOtherCamera_;
		public bool isEventSeamless_;
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

            var dummy = new InGameCameraGeneralBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralBase", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralBase.ObjectType, null, properties, 0, 176);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralBase", base.GetFieldProperties(), -1360307711, 882167849);
            
			fieldProperties.AddProperty(new Property("filterLevel_", 124193320, "Black.Camera.CameraFilterLevel", 8, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessGroupId_", 119581881, "SQEX.Ebony.Std.Fixid", 12, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessId_", 845162028, "Ebony.Base.String", 16, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("stopFilterType_", 3896259952, "Black.Camera.StopCameraFilterType", 32, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnableSwitchOtherCamera_", 2148770948, "bool", 36, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnableForceStopOtherCamera_", 4053675315, "bool", 37, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEventSeamless_", 891408881, "bool", 38, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessInterpMode_", 2284664936, "Black.Camera.SeamlessInterpMode", 40, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessInterpCloneReleaseMode_", 4190490874, "Black.Camera.SeamlessInterpCloneReleaseMode", 44, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessInterpCloneAutoReleaseTime_", 2087610095, "float", 48, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessCloneData_", 2316245948, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone", 56, 40, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessInterpCloneControlTurn_", 1610712634, "Black.Camera.Struct.CameraControlTurn", 104, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseDefaultAngleLimitTiltAtEventSeamless_", 3153703281, "bool", 160, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessInterpAngleLimitTiltMin_", 3922170044, "float", 164, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("seamlessInterpAngleLimitTiltMax_", 3275654686, "float", 168, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isSeamlessInterpCheckCollision_", 3021459793, "bool", 172, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}