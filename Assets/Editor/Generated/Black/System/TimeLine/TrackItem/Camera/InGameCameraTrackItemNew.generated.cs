using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class InGameCameraTrackItemNew : Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralNew generalData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovNew fovData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraTrackItemNew();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItemNew", 0, Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItemNew.ObjectType, null, properties, 0, 1808);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItemNew", base.GetFieldProperties(), -1889087671, 1195729093);
            return fieldProperties;
        }

		
    }
}