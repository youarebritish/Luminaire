using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class InGameCameraTurnYawTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string yawId_;
		public string yawOffsetId_;
		public string yawSignId_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYaw turnYawData_;
		public SQEX.Ebony.Framework.TimeControl.CurveList curveList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraTurnYawTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.InGameCameraTurnYawTrackItem", 0, Black.System.TimeLine.TrackItem.Camera.InGameCameraTurnYawTrackItem.ObjectType, null, properties, 0, 232);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.InGameCameraTurnYawTrackItem", base.GetFieldProperties(), 1364207952, -935370991);
            return fieldProperties;
        }

		
    }
}