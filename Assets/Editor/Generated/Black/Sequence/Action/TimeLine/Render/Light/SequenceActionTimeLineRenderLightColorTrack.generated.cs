using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render.Light
{
    public partial class SequenceActionTimeLineRenderLightColorTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isColorCurveEnable_;
		public Black.System.TimeLine.TrackItem.Render.Light.LightColorTrackItem masterTrackItem_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineRenderLightColorTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.Light.SequenceActionTimeLineRenderLightColorTrack", 0, Black.Sequence.Action.TimeLine.Render.Light.SequenceActionTimeLineRenderLightColorTrack.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.Light.SequenceActionTimeLineRenderLightColorTrack", base.GetFieldProperties(), 1188247303, 892032255);
            return fieldProperties;
        }

		
    }
}