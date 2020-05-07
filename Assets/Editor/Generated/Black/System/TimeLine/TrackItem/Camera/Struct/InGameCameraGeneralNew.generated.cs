using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraGeneralNew : Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralStart startData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralEnd endData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraGeneralNew();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralNew", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralNew.ObjectType, null, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralNew", base.GetFieldProperties(), 1199235667, 1048778738);
            
			fieldProperties.AddProperty(new Property("startData_", 2680278824, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralStart", 176, 184, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endData_", 1827778047, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralEnd", 360, 208, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}