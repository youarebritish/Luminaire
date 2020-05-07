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
            
			
			
			return fieldProperties;
        }

		
    }
}