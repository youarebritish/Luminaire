using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraGeneralStart : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isUse_;
		public bool isCutChangeOrder_;
		public bool isNeedClearCameraContainerBlendDataWhenCutChange_;
		public float interpTime_;
		public int interpBlendMode_;
		public bool isUseCommonData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart pogData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart povData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYawStart turnYawData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTiltStart turnTiltData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollStart turnRollData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovStartNew fovData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraGeneralStart();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralStart", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralStart.ObjectType, null, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralStart", base.GetFieldProperties(), 1239833791, -742281100);
            
			
			
			return fieldProperties;
        }

		
    }
}