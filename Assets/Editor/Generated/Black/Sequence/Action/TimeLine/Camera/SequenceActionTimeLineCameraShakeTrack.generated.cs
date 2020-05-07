using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera
{
    public partial class SequenceActionTimeLineCameraShakeTrack : Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraShakeTrackNormalCurve
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool shakeOffsetFlag_;
		public bool rollZFlag_;
		public bool undampedDistanceFlag_;
		public bool endAttenuationDistanceFlag_;
		public bool randomShakeTimeWidthFlag_;
		public bool randomShakeScaleFlag_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraShakeTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraShakeTrack", 0, Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraShakeTrack.ObjectType, null, properties, 0, 752);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraShakeTrack", base.GetFieldProperties(), 1821086065, 926061527);
            
			
			
			return fieldProperties;
        }

		
    }
}