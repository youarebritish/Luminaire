using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor
{
    public partial class SequenceActionTimeLineCameraChangeSceneTrackCCFCamera : Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineCameraChangeSceneTrack
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraChangeSceneTrackCCFCamera();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineCameraChangeSceneTrackCCFCamera", 0, Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineCameraChangeSceneTrackCCFCamera.ObjectType, null, properties, 0, 584);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineCameraChangeSceneTrackCCFCamera", base.GetFieldProperties(), 108198261, 940494140);
            return fieldProperties;
        }

		
    }
}