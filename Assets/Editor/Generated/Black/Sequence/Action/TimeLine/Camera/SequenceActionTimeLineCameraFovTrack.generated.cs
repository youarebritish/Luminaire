using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera
{
    public partial class SequenceActionTimeLineCameraFovTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackInterpBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool fovFlag_;
		public SQEX.Ebony.Framework.TimeControl.TimeLine.CameraFovTrackItem masterTrackItem_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraFovTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraFovTrack", 0, Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraFovTrack.ObjectType, null, properties, 0, 528);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraFovTrack", base.GetFieldProperties(), 455788731, -271809517);
            return fieldProperties;
        }

		
    }
}