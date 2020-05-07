using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera
{
    public partial class SequenceActionTimeLineCameraInGameTrack : Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin eyeTargetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnYawPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnTiltPin_;
		public Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItem masterTrackItem_;
		public bool isNeedTurnYaw_;
		public bool isNeedTurnTilt_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraInGameTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameTrack", 0, Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameTrack.ObjectType, null, properties, 0, 2384);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameTrack", base.GetFieldProperties(), 1295662871, 732374047);
            
			
			
			return fieldProperties;
        }

		
    }
}