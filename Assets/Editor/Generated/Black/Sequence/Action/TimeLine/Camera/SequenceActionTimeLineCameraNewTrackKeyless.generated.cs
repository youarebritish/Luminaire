using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera
{
    public partial class SequenceActionTimeLineCameraNewTrackKeyless : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool pogFlag_;
		public bool povFlag_;
		public bool fovFlag_;
		public bool rollFlag_;
		public Black.Camera.Struct.CameraControlTurn controlTurn_;
		public Black.System.TimeLine.TrackItem.Camera.CameraNewTrackItem masterTrackItem_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraNewTrackKeyless();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraNewTrackKeyless", 0, Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraNewTrackKeyless.ObjectType, null, properties, 0, 576);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraNewTrackKeyless", base.GetFieldProperties(), 2136033729, -601213507);
            
			
			
			return fieldProperties;
        }

		
    }
}