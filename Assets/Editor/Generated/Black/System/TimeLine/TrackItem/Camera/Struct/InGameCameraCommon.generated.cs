using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraCommon : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int mode;
		public int startEndBlendMode_;
		public bool isCheckCollision_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCollision collisionData_;
		public bool isEnableCancelWhenPCFrameOut_;
		public bool isEnableCancelWhenTerribleCollieded_;
		public bool isCutChangeOrder;
		public bool isNeedClearCameraContainerBlendDataWhenCutChange_;
		public bool isUseBattleAssistRotationWhenNotControlingYaw_;
		public bool isIgnoreCameraShake_;
		public int autoCompositionShotType_;
		public bool isNeedCaptureForOtherRelativeTarget_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraCommon();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCommon", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCommon.ObjectType, null, properties, 0, 80);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCommon", base.GetFieldProperties(), 1242605330, 1235712562);
            
			fieldProperties.AddProperty(new Property("mode", 3966689298, "Black.Camera.InGameSeamlessTargetMode", 8, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("startEndBlendMode_", 723897861, "Black.Camera.SeamlessInGameSeparateStartEndBlendMode", 12, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCheckCollision_", 1357258370, "bool", 16, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("collisionData_", 1610769336, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCollision", 24, 40, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnableCancelWhenPCFrameOut_", 2316588487, "bool", 64, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnableCancelWhenTerribleCollieded_", 3169225281, "bool", 65, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCutChangeOrder", 3243753193, "bool", 66, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNeedClearCameraContainerBlendDataWhenCutChange_", 2284833010, "bool", 67, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseBattleAssistRotationWhenNotControlingYaw_", 3110327259, "bool", 68, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isIgnoreCameraShake_", 2675112431, "bool", 69, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoCompositionShotType_", 932543529, "Black.Camera.AutoCompositionShotType", 72, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNeedCaptureForOtherRelativeTarget_", 4141653000, "bool", 76, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}