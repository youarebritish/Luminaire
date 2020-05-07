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
            
			fieldProperties.AddProperty(new Property("positionFlag_", 1431188689, "bool", 336, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotationFlag_", 1122119386, "bool", 337, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("scalingFlag_", 3979182841, "bool", 338, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseSetPos_", 2014981483, "bool", 339, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("setPosType_", 2082547708, "Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineActorMovementNewTrack.SetPosType", 340, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveType_", 2401107961, "Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineActorMovementNewTrack.MoveType", 344, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveFrameType", 1889103065, "Black.System.TimeLine.TimeLineManager.MoveFrameType", 348, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isRemoveRoll_", 2157122027, "bool", 360, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isKeepTiltZero_", 2501551690, "bool", 361, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("masterTrackItem_", 1305972098, "Black.System.TimeLine.TrackItem.ActorMovementNewTrackItem", 368, 160, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}