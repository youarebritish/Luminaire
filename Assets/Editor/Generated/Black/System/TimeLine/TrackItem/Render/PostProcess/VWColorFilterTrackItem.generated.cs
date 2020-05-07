using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Render.PostProcess
{
    public partial class VWColorFilterTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool propCAT_;
		public bool propsRGBGamma_;
		public bool propDither_;
		public float propSceneEv_;
		public float propUserEv_;
		public bool propEnabledWhite_;
		public float propGM_;
		public float propBY_;
		public bool propEnabledToneCurve_;
		public float propHighRange_;
		public float propContrast_;
		public float propZeroSlope_;
		public float propDark_;
		public bool propEnabledHue_;
		public float proprotM_;
		public float proprotY_;
		public float proprotG_;
		public float proprotB_;
		public bool propEnabledSaturationALL_;
		public bool propEnabledSaturation_;
		public float propsAll_;
		public float propsM_;
		public float propsY_;
		public float propsG_;
		public float propsB_;
		public bool propEnabledSaturationClamp_;
		public float propscAll_;
		public float propscM_;
		public float propscY_;
		public float propscG_;
		public float propscB_;
		public bool propEnabledSaturationByKido_;
		public float props0_;
		public float props1_;
		public float props2_;
		public float props3_;
		public float props4_;
		public float propsM0_;
		public float propsM1_;
		public float propsM2_;
		public float propsM3_;
		public float propsM4_;
		public float propsY0_;
		public float propsY1_;
		public float propsY2_;
		public float propsY3_;
		public float propsY4_;
		public float propsG0_;
		public float propsG1_;
		public float propsG2_;
		public float propsG3_;
		public float propsG4_;
		public float propsB0_;
		public float propsB1_;
		public float propsB2_;
		public float propsB3_;
		public float propsB4_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VWColorFilterTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Render.PostProcess.VWColorFilterTrackItem", 0, Black.System.TimeLine.TrackItem.Render.PostProcess.VWColorFilterTrackItem.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Render.PostProcess.VWColorFilterTrackItem", base.GetFieldProperties(), 731056422, -1217140648);
            return fieldProperties;
        }

		
    }
}