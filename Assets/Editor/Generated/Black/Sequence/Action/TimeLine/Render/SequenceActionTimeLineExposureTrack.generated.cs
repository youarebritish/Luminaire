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
            
			fieldProperties.AddProperty(new Property("isEnabled_", 1211060515, "bool", 320, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("enableWeather_", 1384777099, "bool", 321, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("useRelativeValueForMeasureMinMax_", 336106823, "bool", 322, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("exposure_", 2450507277, "float", 324, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("enableAutoExposure_", 2292919737, "bool", 328, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("autoExposureUp_", 2729641199, "float", 332, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("autoExposureDown_", 2329027196, "float", 336, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("autoExposureBase_", 140236231, "float", 340, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("autoExposureMin_", 3391681970, "float", 344, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("autoExposureMax_", 2744578232, "float", 348, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("autoExposureSpeedUp_", 3180301688, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("autoExposureSpeedDown_", 1999423415, "float", 356, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			
			
			return fieldProperties;
        }

		
    }
}