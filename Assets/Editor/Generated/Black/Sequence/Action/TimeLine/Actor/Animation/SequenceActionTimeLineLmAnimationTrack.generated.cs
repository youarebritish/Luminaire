using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor.Animation
{
    public partial class SequenceActionTimeLineLmAnimationTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint layerId_;
		public bool isUseFrameSkipBug_;
		public int autoGenderSelect_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineLmAnimationTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.Animation.SequenceActionTimeLineLmAnimationTrack", 0, Black.Sequence.Action.TimeLine.Actor.Animation.SequenceActionTimeLineLmAnimationTrack.ObjectType, null, properties, 0, 488);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.Animation.SequenceActionTimeLineLmAnimationTrack", base.GetFieldProperties(), 1611077512, 45794267);
            return fieldProperties;
        }

		
    }
}