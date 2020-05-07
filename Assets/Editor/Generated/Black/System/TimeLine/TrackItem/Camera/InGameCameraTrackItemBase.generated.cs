using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class InGameCameraTrackItemBase : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCommon commonData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPog pogData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov povData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurn turnData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYaw turnYawData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTilt turnTiltData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRoll turnRollData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraTrackItemBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItemBase", 0, Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItemBase.ObjectType, null, properties, 0, 1168);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItemBase", base.GetFieldProperties(), 34578881, -1376192246);
            
			
			
			return fieldProperties;
        }

		
    }
}