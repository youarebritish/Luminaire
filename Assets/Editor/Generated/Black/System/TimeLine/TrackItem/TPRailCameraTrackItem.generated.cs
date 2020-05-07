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
            
			fieldProperties.AddIndirectlyProperty(new Property("name_", 182823483, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startTime_", 140908163, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("duration_", 1282328598, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pog_", 2731150478, "Luminous.Math.VectorA", 144, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("pov_", 1659795623, "Luminous.Math.VectorA", 160, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("roll_", 1959619923, "float", 176, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rollDirection_", 3423543028, "SQEX.Ebony.Framework.TimeControl.RotationDirection", 180, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("interpMode_", 1180138017, "SQEX.Ebony.Framework.TimeControl.InterpMode", 184, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isUseCurrentCameraPosition_", 1107821086, "bool", 188, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("pcPosition_", 2515614584, "Luminous.Math.VectorA", 224, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("pcRotation_", 1444790023, "Luminous.Math.VectorA", 240, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("fov_", 308377913, "float", 256, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("railValidAreaWidth_", 848066077, "float", 260, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}