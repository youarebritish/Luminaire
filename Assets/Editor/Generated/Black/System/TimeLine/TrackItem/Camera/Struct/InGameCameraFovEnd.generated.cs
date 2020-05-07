using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraFovEnd : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isChangeEndFov_;
		public int fovEndInterpMode_;
		public float fovEndInterpTime_;
		public float fovEndFInterpToSpeed_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraFovEnd();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovEnd", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovEnd.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovEnd", base.GetFieldProperties(), -987091949, 385589290);
            
			
			
			fieldProperties.AddProperty(new Property("isChangeEndFov_", 3066722358, "bool", 8, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("fovEndInterpMode_", 2601926677, "Black.Camera.BlendModeType", 12, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("fovEndInterpTime_", 3673886931, "float", 16, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fovEndFInterpToSpeed_", 3805308594, "float", 20, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}