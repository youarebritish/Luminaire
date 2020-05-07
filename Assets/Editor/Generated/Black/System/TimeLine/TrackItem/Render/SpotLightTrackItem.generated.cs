using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Render
{
    public partial class SpotLightTrackItem : Black.System.TimeLine.TrackItem.Render.LightTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float coneAngle_;
		public float penumbraAngle_;
		public float torchIntensity_;
		public float torchFalloff_;
		public float torchNoiseFrequency_;
		public float torchNoiseVariance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SpotLightTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Render.SpotLightTrackItem", 0, Black.System.TimeLine.TrackItem.Render.SpotLightTrackItem.ObjectType, null, properties, 0, 288);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Render.SpotLightTrackItem", base.GetFieldProperties(), -1300881162, 715311173);
            return fieldProperties;
        }

		
    }
}