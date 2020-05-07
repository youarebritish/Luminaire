using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.General
{
    public partial class SequenceActionTimeLineSoundMusicTrackGeneral : Black.Sequence.Action.TimeLine.Sound.SequenceActionTimeLineSoundTrackCommon
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isMovieValid_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineSoundMusicTrackGeneral();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.General.SequenceActionTimeLineSoundMusicTrackGeneral", 0, Black.Sequence.Action.TimeLine.General.SequenceActionTimeLineSoundMusicTrackGeneral.ObjectType, null, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.General.SequenceActionTimeLineSoundMusicTrackGeneral", base.GetFieldProperties(), 2122652970, -763658366);
            return fieldProperties;
        }

		
    }
}