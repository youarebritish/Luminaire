using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class TPRailCameraTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.CameraTrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 pcPosition_;
		public UnityEngine.Vector4 pcRotation_;
		public float fov_;
		public float railValidAreaWidth_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TPRailCameraTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.TPRailCameraTrackItem", 0, Black.System.TimeLine.TrackItem.TPRailCameraTrackItem.ObjectType, null, properties, 0, 336);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.TPRailCameraTrackItem", base.GetFieldProperties(), 1920991989, 1851703812);
            
			
			
			return fieldProperties;
        }

		
    }
}