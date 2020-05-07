using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor
{
    public partial class SequenceActionTimeLineActorMovementNewTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool positionFlag_;
		public bool rotationFlag_;
		public bool scalingFlag_;
		public bool isUseSetPos_;
		public int setPosType_;
		public int moveType_;
		public int moveFrameType;
		public bool isRemoveRoll_;
		public bool isKeepTiltZero_;
		public Black.System.TimeLine.TrackItem.ActorMovementNewTrackItem masterTrackItem_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineActorMovementNewTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineActorMovementNewTrack", 0, Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineActorMovementNewTrack.ObjectType, null, properties, 0, 576);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineActorMovementNewTrack", base.GetFieldProperties(), -465809041, -647522364);
            
			
			
			return fieldProperties;
        }

		
    }
}