using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera
{
    public partial class SequenceActionTimeLineCameraInGameGeneralTrack : Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraInGameGeneralTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameGeneralTrack", 0, Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameGeneralTrack.ObjectType, null, properties, 0, 2016);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameGeneralTrack", base.GetFieldProperties(), -867145170, 1683630813);
            return fieldProperties;
        }

		
    }
}