using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraGeneralEnd : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isUse_;
		public bool backToNormalIsCutChangeOrder_;
		public int backToNormalCoordInterpType_;
		public float backToNormalInterpTime_;
		public float backToNormalCameraTime1_;
		public float backToNormalCameraTime2_;
		public int backToNormalInterpBlendMode_;
		public bool isUseCommonData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYawEnd turnYawData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTiltEnd turnTiltData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollEnd turnRollData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovEnd fovData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraGeneralEnd();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralEnd", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralEnd.ObjectType, null, properties, 0, 208);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralEnd", base.GetFieldProperties(), -1615582886, -1378610112);
            
			
			
			return fieldProperties;
        }

		
    }
}