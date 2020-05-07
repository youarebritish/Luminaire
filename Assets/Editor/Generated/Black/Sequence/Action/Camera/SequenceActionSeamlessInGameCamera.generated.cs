using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionSeamlessInGameCamera : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin endPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnDirectionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cameraPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnTiltPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnYawPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin povOffsetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin eyeTargetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pogOffsetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public Black.System.TimeLine.TrackItem.Camera.InGameCameraTrackItem seamlessParameter_;
		public bool isNeedTurnYaw_;
		public bool isNeedTurnTilt_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSeamlessInGameCamera();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCamera", 0, Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCamera.ObjectType, null, properties, 0, 2704);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCamera", base.GetFieldProperties(), -1508499149, 1206890769);
            return fieldProperties;
        }

		
    }
}