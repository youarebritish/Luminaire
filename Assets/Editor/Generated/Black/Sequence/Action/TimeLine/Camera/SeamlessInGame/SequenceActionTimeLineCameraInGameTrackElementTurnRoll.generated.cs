using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera.SeamlessInGame
{
    public partial class SequenceActionTimeLineCameraInGameTrackElementTurnRoll : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRoll masterRollData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraInGameTrackElementTurnRoll();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SeamlessInGame.SequenceActionTimeLineCameraInGameTrackElementTurnRoll", 0, Black.Sequence.Action.TimeLine.Camera.SeamlessInGame.SequenceActionTimeLineCameraInGameTrackElementTurnRoll.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SeamlessInGame.SequenceActionTimeLineCameraInGameTrackElementTurnRoll", base.GetFieldProperties(), 2138629554, -453073668);
            return fieldProperties;
        }

		
    }
}