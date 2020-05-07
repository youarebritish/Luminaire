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
            
			
			
			return fieldProperties;
        }

		
    }
}