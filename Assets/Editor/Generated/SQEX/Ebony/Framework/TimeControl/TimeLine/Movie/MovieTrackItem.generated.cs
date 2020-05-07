using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.TimeControl.TimeLine.Movie
{
    public partial class MovieTrackItem : SQEX.Ebony.Framework.TimeControl.TimeLine.TrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string sourcePath_;
		public uint label_;
		public int pathType_;
		public int voiceMatching_;
		public bool useLocalizeFile_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MovieTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.TimeControl.TimeLine.Movie.MovieTrackItem", 0, SQEX.Ebony.Framework.TimeControl.TimeLine.Movie.MovieTrackItem.ObjectType, null, properties, 0, 120);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.TimeControl.TimeLine.Movie.MovieTrackItem", base.GetFieldProperties(), 1357203848, -203323235);
            return fieldProperties;
        }

		
    }
}