using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Movie
{
    public partial class SequenceActionTimeLineMovieTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isOnlyMovieVoice_;
		public bool isMute_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineMovieTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Movie.SequenceActionTimeLineMovieTrack", 0, Black.Sequence.Action.TimeLine.Movie.SequenceActionTimeLineMovieTrack.ObjectType, null, properties, 0, 408);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Movie.SequenceActionTimeLineMovieTrack", base.GetFieldProperties(), -1340805543, -1382025214);
            
			
			
			return fieldProperties;
        }

		
    }
}