using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraFov : Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovNew
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovStart startData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovEnd endData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraFov();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFov", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFov.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFov", base.GetFieldProperties(), -490272741, -862737390);
            return fieldProperties;
        }

		
    }
}