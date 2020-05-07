using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class InGameCameraTrackItem : Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneral generalData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFov fovData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItem", 0, Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItem.ObjectType, null, properties, 0, 1504);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItem", base.GetFieldProperties(), -209185905, 2050174665);
            return fieldProperties;
        }

		
    }
}