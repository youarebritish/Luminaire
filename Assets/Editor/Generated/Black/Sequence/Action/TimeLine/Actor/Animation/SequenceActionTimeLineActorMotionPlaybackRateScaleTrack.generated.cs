using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor.Animation
{
    public partial class SequenceActionTimeLineActorMotionPlaybackRateScaleTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float playbackRateScale_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineActorMotionPlaybackRateScaleTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.Animation.SequenceActionTimeLineActorMotionPlaybackRateScaleTrack", 0, Black.Sequence.Action.TimeLine.Actor.Animation.SequenceActionTimeLineActorMotionPlaybackRateScaleTrack.ObjectType, null, properties, 0, 344);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.Animation.SequenceActionTimeLineActorMotionPlaybackRateScaleTrack", base.GetFieldProperties(), 1547406559, 1429282288);
            
			fieldProperties.AddProperty(new Property("playbackRateScale_", 616051513, "float", 336, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			
			
			return fieldProperties;
        }

		
    }
}