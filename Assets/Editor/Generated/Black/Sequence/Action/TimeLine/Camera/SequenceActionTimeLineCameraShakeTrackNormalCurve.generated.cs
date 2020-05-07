using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera
{
    public partial class SequenceActionTimeLineCameraShakeTrackNormalCurve : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enableRandomShakeOffset_;
		public int shakeRandomFactorRangeMode_;
		public bool enableRandomRollZ_;
		public int rollZRandomFactorRangeMode_;
		public bool enableRandomUndampedDistance_;
		public int undampedDistanceRandomFactorRangeMode_;
		public bool enableRandomEndAttenuationDistance_;
		public int endAttenuationDistanceRandomFactorRangeMode_;
		public bool enableRandomShakeTimeWidth_;
		public bool enableRandomOffsetRollScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cameraActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sourceActorPin_;
		public Black.System.TimeLine.TrackItem.Camera.CameraShakeTrackItem masterTrackItem_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraShakeTrackNormalCurve();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraShakeTrackNormalCurve", 0, Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraShakeTrackNormalCurve.ObjectType, null, properties, 0, 736);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraShakeTrackNormalCurve", base.GetFieldProperties(), -371611817, -1786498253);
            
			
			
			return fieldProperties;
        }

		
    }
}