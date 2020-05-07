using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class InGameCameraFovTrackItemNew : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string fovId_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovNew fovData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraFovTrackItemNew();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.InGameCameraFovTrackItemNew", 0, Black.System.TimeLine.TrackItem.Camera.InGameCameraFovTrackItemNew.ObjectType, null, properties, 0, 176);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.InGameCameraFovTrackItemNew", base.GetFieldProperties(), -836947333, 1403933992);
            return fieldProperties;
        }

		
    }
}