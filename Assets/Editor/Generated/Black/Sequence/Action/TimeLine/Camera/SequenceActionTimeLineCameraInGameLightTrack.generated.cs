using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera
{
    public partial class SequenceActionTimeLineCameraInGameLightTrack : Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameLightBaseTrack
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraInGameLightTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameLightTrack", 0, Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameLightTrack.ObjectType, null, properties, 0, 2320);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameLightTrack", base.GetFieldProperties(), 802071512, 1483860420);
            return fieldProperties;
        }

		
    }
}