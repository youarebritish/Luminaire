using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render.PostProcess
{
    public partial class SequenceActionTimeLineMotionBlurTrack : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public bool enableDynamicParams_;
		public float shutterAngle_;
		public float shutterAngleDynamic_;
		public float cameraMotionStrength_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineMotionBlurTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineMotionBlurTrack", 0, Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineMotionBlurTrack.ObjectType, null, properties, 0, 344);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineMotionBlurTrack", base.GetFieldProperties(), 1662017199, 742792715);
            return fieldProperties;
        }

		
    }
}