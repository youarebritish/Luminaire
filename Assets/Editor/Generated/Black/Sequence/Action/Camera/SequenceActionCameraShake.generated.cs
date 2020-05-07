using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionCameraShake : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cameraActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sourceActorPin_;
		public bool enableRandomShakeOffset_;
		public int shakeRandomFactorRangeMode_;
		public bool enableRandomRollZ_;
		public int rollZRandomFactorRangeMode_;
		public bool enableRandomUndampedDistance_;
		public int undampedDistanceRandomFactorRangeMode_;
		public bool enableRandomEndAttenuationDistance_;
		public int endAttenuationDistanceRandomFactorRangeMode_;
		public float activeTime_;
		public bool enableRandomShakeTimeWidth_;
		public Black.System.TimeLine.TrackItem.Camera.CameraShakeNodeTrackItem shakeParameter_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraShake();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionCameraShake", 0, Black.Sequence.Action.Camera.SequenceActionCameraShake.ObjectType, null, properties, 0, 1120);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionCameraShake", base.GetFieldProperties(), 217117542, -3787018);
            return fieldProperties;
        }

		
    }
}