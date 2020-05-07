using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render.PostProcess
{
    public partial class SequenceActionTimeLineVWColorFilterTrack : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.System.TimeLine.TrackItem.Render.PostProcess.VWColorFilterTrackItem masterTrackItem_;
		public bool propSceneEvFlag_;
		public bool propUserEvFlag_;
		public bool propGMFlag_;
		public bool propBYFlag_;
		public bool propHighRangeFlag_;
		public bool propContrastFlag_;
		public bool propZeroSlopeFlag_;
		public bool propDarkFlag_;
		public bool proprotMFlag_;
		public bool proprotYFlag_;
		public bool proprotGFlag_;
		public bool proprotBFlag_;
		public bool propsAllFlag_;
		public bool propsMFlag_;
		public bool propsYFlag_;
		public bool propsGFlag_;
		public bool propsBFlag_;
		public bool propscAllFlag_;
		public bool propscMFlag_;
		public bool propscYFlag_;
		public bool propscGFlag_;
		public bool propscBFlag_;
		public bool props0Flag_;
		public bool props1Flag_;
		public bool props2Flag_;
		public bool props3Flag_;
		public bool props4Flag_;
		public bool propsM0Flag_;
		public bool propsM1Flag_;
		public bool propsM2Flag_;
		public bool propsM3Flag_;
		public bool propsM4Flag_;
		public bool propsY0Flag_;
		public bool propsY1Flag_;
		public bool propsY2Flag_;
		public bool propsY3Flag_;
		public bool propsY4Flag_;
		public bool propsG0Flag_;
		public bool propsG1Flag_;
		public bool propsG2Flag_;
		public bool propsG3Flag_;
		public bool propsG4Flag_;
		public bool propsB0Flag_;
		public bool propsB1Flag_;
		public bool propsB2Flag_;
		public bool propsB3Flag_;
		public bool propsB4Flag_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineVWColorFilterTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineVWColorFilterTrack", 0, Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineVWColorFilterTrack.ObjectType, null, properties, 0, 672);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineVWColorFilterTrack", base.GetFieldProperties(), 861028660, -2027172143);
            
			fieldProperties.AddProperty(new Property("masterTrackItem_", 1305972098, "Black.System.TimeLine.TrackItem.Render.PostProcess.VWColorFilterTrackItem", 320, 304, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("propSceneEvFlag_", 2234314542, "bool", 624, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propUserEvFlag_", 1004645427, "bool", 625, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propGMFlag_", 39716183, "bool", 626, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propBYFlag_", 3705307432, "bool", 627, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propHighRangeFlag_", 2077114644, "bool", 628, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propContrastFlag_", 1791045537, "bool", 629, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propZeroSlopeFlag_", 2561176192, "bool", 630, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propDarkFlag_", 3703022803, "bool", 631, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("proprotMFlag_", 3987954095, "bool", 632, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("proprotYFlag_", 2579912947, "bool", 633, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("proprotGFlag_", 3526949957, "bool", 634, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("proprotBFlag_", 508483368, "bool", 635, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsAllFlag_", 3361970959, "bool", 636, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsMFlag_", 4093774691, "bool", 637, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsYFlag_", 756894463, "bool", 638, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsGFlag_", 2092030553, "bool", 639, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsBFlag_", 202505220, "bool", 640, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propscAllFlag_", 2352261608, "bool", 641, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propscMFlag_", 3369280396, "bool", 642, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propscYFlag_", 1528999040, "bool", 643, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propscGFlag_", 1397454454, "bool", 644, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propscBFlag_", 2666240731, "bool", 645, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("props0Flag_", 3063718278, "bool", 646, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("props1Flag_", 3840951127, "bool", 647, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("props2Flag_", 1461020980, "bool", 648, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("props3Flag_", 4183620789, "bool", 649, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("props4Flag_", 2814840442, "bool", 650, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsM0Flag_", 2391862955, "bool", 651, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsM1Flag_", 3759210682, "bool", 652, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsM2Flag_", 1896624073, "bool", 653, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsM3Flag_", 2890958104, "bool", 654, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsM4Flag_", 1978926487, "bool", 655, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsY0Flag_", 3779087199, "bool", 656, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsY1Flag_", 2202797358, "bool", 657, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsY2Flag_", 1846757949, "bool", 658, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsY3Flag_", 4065377756, "bool", 659, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsY4Flag_", 2696086483, "bool", 660, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsG0Flag_", 353400261, "bool", 661, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsG1Flag_", 554419588, "bool", 662, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsG2Flag_", 1876937191, "bool", 663, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsG3Flag_", 3943936598, "bool", 664, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsG4Flag_", 2443944921, "bool", 665, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsB0Flag_", 127751998, "bool", 666, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsB1Flag_", 4129139183, "bool", 667, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsB2Flag_", 341049772, "bool", 668, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsB3Flag_", 2935186829, "bool", 669, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("propsB4Flag_", 942196018, "bool", 670, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}