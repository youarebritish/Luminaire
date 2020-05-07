using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class InGameCameraGeneralTrackItemNew : Black.System.TimeLine.TrackItem.BlendTrackItemBaseNoResource
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string lastViewKeepId_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralNew generalData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraGeneralTrackItemNew();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.InGameCameraGeneralTrackItemNew", 0, Black.System.TimeLine.TrackItem.Camera.InGameCameraGeneralTrackItemNew.ObjectType, null, properties, 0, 712);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.InGameCameraGeneralTrackItemNew", base.GetFieldProperties(), 1472060458, -2078175781);
            
			fieldProperties.AddProperty(new Property("lastViewKeepId_", 3613130477, "Ebony.Base.String", 128, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("generalData_", 3152804964, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralNew", 144, 568, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}