using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class InGameCameraPovPCKeepTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string pogId_;
		public string pogMatrixId_;
		public string pogOffsetId_;
		public string pogSignId_;
		public string povDistanceId_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPog pogData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov povData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraPovPCKeepTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.InGameCameraPovPCKeepTrackItem", 0, Black.System.TimeLine.TrackItem.Camera.InGameCameraPovPCKeepTrackItem.ObjectType, null, properties, 0, 416);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.InGameCameraPovPCKeepTrackItem", base.GetFieldProperties(), 2667630, -1697406735);
            
			
			
			return fieldProperties;
        }

		
    }
}