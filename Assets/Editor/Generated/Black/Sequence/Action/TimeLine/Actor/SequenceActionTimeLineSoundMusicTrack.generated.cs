using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor
{
    public partial class SequenceActionTimeLineSoundMusicTrack : Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineSoundTrack
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineSoundMusicTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineSoundMusicTrack", 0, Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineSoundMusicTrack.ObjectType, null, properties, 0, 408);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineSoundMusicTrack", base.GetFieldProperties(), 207382691, 246687362);
            return fieldProperties;
        }

		
    }
}