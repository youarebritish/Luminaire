using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera
{
    public partial class SequenceActionTimeLineCameraInGameLightBaseTrack : Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraInGameLightBaseTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameLightBaseTrack", 0, Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameLightBaseTrack.ObjectType, null, properties, 0, 2320);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameLightBaseTrack", base.GetFieldProperties(), -2001129913, 1763965521);
            
			
			
			return fieldProperties;
        }

		
    }
}