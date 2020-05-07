using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class CameraNewTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 pog_;
		public UnityEngine.Vector4 pov_;
		public float fov_;
		public float roll_;
		public int rollDirection_;
		public int interpMode_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CameraNewTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.CameraNewTrackItem", 0, Black.System.TimeLine.TrackItem.Camera.CameraNewTrackItem.ObjectType, null, properties, 0, 144);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.CameraNewTrackItem", base.GetFieldProperties(), 1100155877, 1714459527);
            
			
			
			return fieldProperties;
        }

		
    }
}