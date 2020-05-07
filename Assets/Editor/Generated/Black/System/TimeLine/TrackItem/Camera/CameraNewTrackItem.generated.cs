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
            
			fieldProperties.AddProperty(new Property("pog_", 2731150478, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddProperty(new Property("pov_", 1659795623, "Luminous.Math.VectorA", 112, 16, 1, Property.PrimitiveType.Vector4, 0, (char)1));
			fieldProperties.AddProperty(new Property("fov_", 308377913, "float", 128, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("roll_", 1959619923, "float", 132, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("rollDirection_", 3423543028, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 136, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("interpMode_", 1180138017, "SQEX.Ebony.Framework.TimeControl.InterpMode", 140, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}