using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor
{
    public partial class SequenceActionTimeLineMotionTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool stopMorpheme_;
		public bool isRestartMorphemeWhenFinished_;
		public bool isResetTransOrigin_;
		public bool isUseCutSceneMotion_;
		public bool isWarpZeroFrame_;
		public bool isIgnoreBaseScale_;
		public bool isResetPhysics_;
		public string idleMotionSourcePath_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineMotionTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineMotionTrack", 0, Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineMotionTrack.ObjectType, null, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineMotionTrack", base.GetFieldProperties(), -1910248416, 1201788451);
            return fieldProperties;
        }

		
    }
}