using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class InGameCameraTurnTiltTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string tiltId_;
		public string tiltOffsetId_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTilt turnTiltData_;
		public SQEX.Ebony.Framework.TimeControl.CurveList curveList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraTurnTiltTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.InGameCameraTurnTiltTrackItem", 0, Black.System.TimeLine.TrackItem.Camera.InGameCameraTurnTiltTrackItem.ObjectType, null, properties, 0, 208);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.InGameCameraTurnTiltTrackItem", base.GetFieldProperties(), 890368831, 1760918290);
            return fieldProperties;
        }

		
    }
}