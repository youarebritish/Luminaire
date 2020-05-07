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
            
			
			
			return fieldProperties;
        }

		
    }
}