using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render
{
    public partial class SequenceActionTimeLineExposureTrack : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isEnabled_;
		public bool enableWeather_;
		public bool useRelativeValueForMeasureMinMax_;
		public float exposure_;
		public bool enableAutoExposure_;
		public float autoExposureUp_;
		public float autoExposureDown_;
		public float autoExposureBase_;
		public float autoExposureMin_;
		public float autoExposureMax_;
		public float autoExposureSpeedUp_;
		public float autoExposureSpeedDown_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineExposureTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.SequenceActionTimeLineExposureTrack", 0, Black.Sequence.Action.TimeLine.Render.SequenceActionTimeLineExposureTrack.ObjectType, null, properties, 0, 376);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.SequenceActionTimeLineExposureTrack", base.GetFieldProperties(), 613391715, -1635142565);
            
			
			
			return fieldProperties;
        }

		
    }
}