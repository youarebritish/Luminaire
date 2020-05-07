using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine
{
    public partial class SequenceActionTimeLineMovementTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackInterpMovementBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isUseSetPos_;
		public bool isUnableBeforeFirstKey_;
		public bool isUnableAfterLastKey_;
		public int moveType_;
		public int useTypePosX_;
		public int useTypePosY_;
		public int useTypePosZ_;
		public int useTypeRotYaw_;
		public int useTypeRotTilt_;
		public int useTypeRotRoll_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineMovementTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.SequenceActionTimeLineMovementTrack", 0, Black.Sequence.Action.TimeLine.SequenceActionTimeLineMovementTrack.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.SequenceActionTimeLineMovementTrack", base.GetFieldProperties(), 842961962, -1277047053);
            
			fieldProperties.AddProperty(new Property("isUseSetPos_", 2014981483, "bool", 416, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUnableBeforeFirstKey_", 1025057297, "bool", 417, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUnableAfterLastKey_", 146225908, "bool", 418, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("moveType_", 2401107961, "Black.Sequence.Action.TimeLine.SequenceActionTimeLineMovementTrack.MoveType", 420, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("useTypePosX_", 546332383, "Black.Sequence.Action.TimeLine.SequenceActionTimeLineMovementTrack.UseType", 432, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("useTypePosY_", 1620247094, "Black.Sequence.Action.TimeLine.SequenceActionTimeLineMovementTrack.UseType", 436, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("useTypePosZ_", 1619805809, "Black.Sequence.Action.TimeLine.SequenceActionTimeLineMovementTrack.UseType", 440, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("useTypeRotYaw_", 389436033, "Black.Sequence.Action.TimeLine.SequenceActionTimeLineMovementTrack.UseType", 444, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("useTypeRotTilt_", 253738591, "Black.Sequence.Action.TimeLine.SequenceActionTimeLineMovementTrack.UseType", 448, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("useTypeRotRoll_", 629149911, "Black.Sequence.Action.TimeLine.SequenceActionTimeLineMovementTrack.UseType", 452, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}