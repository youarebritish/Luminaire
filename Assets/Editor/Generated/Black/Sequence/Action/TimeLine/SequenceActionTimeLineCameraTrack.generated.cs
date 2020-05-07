using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine
{
    public partial class SequenceActionTimeLineCameraTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackInterpMovementBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool pogFlag_;
		public bool povFlag_;
		public bool rollFlag_;
		public Black.Camera.Struct.CameraControlTurn controlTurn_;
		public int useTypePogX_;
		public int useTypePogY_;
		public int useTypePogZ_;
		public int useTypePovX_;
		public int useTypePovY_;
		public int useTypePovZ_;
		public SQEX.Ebony.Framework.TimeControl.TimeLine.CameraTrackItem masterTrackItem_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.SequenceActionTimeLineCameraTrack", 0, Black.Sequence.Action.TimeLine.SequenceActionTimeLineCameraTrack.ObjectType, null, properties, 0, 768);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.SequenceActionTimeLineCameraTrack", base.GetFieldProperties(), -1128376734, 1007610312);
            
			
			
			return fieldProperties;
        }

		
    }
}