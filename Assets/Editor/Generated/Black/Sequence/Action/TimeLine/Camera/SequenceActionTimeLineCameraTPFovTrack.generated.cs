using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera
{
    public partial class SequenceActionTimeLineCameraTPFovTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int filterLevel_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFov masterFovData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraTPFovTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraTPFovTrack", 0, Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraTPFovTrack.ObjectType, null, properties, 0, 536);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraTPFovTrack", base.GetFieldProperties(), 743406196, 1610576946);
            
			
			
			return fieldProperties;
        }

		
    }
}