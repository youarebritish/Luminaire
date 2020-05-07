using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render.PostProcess
{
    public partial class SequenceActionTimeLineNewBokehFilterTrack : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int filterLevel_;
		public bool enabled_;
		public bool enableWeather_;
		public int bokehShape_;
		public float bokehShapeRotation_;
		public float foculLength_;
		public float fNumber_;
		public float focalPlane_;
		public float focalPlaneRadius_;
		public float nearCoCMultiplier_;
		public float farCoCMultiplier_;
		public float maxCoCSizeNear_;
		public float maxCoCSizeFar_;
		public bool vignetteBlur_enabled_;
		public float vignetteBlur_yScale_;
		public float vignetteBlur_start_;
		public float vignetteBlur_strength_;
		public float vignetteBlur_power_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineNewBokehFilterTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineNewBokehFilterTrack", 0, Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineNewBokehFilterTrack.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineNewBokehFilterTrack", base.GetFieldProperties(), -1378842193, -982187144);
            return fieldProperties;
        }

		
    }
}