using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class CameraShakeTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 shakeOffset_;
		public float rollZ_;
		public float undampedDistance_;
		public float endAttenuationDistance_;
		public float randomShakeTimeWidth_;
		public float randomShakeScale_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CameraShakeTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem", 0, Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem.ObjectType, null, properties, 0, 144);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem", base.GetFieldProperties(), 1620006752, 1349536931);
            return fieldProperties;
        }

		
    }
}