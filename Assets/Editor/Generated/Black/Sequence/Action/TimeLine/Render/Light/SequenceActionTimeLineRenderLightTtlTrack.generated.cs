using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render.Light
{
    public partial class SequenceActionTimeLineRenderLightTtlTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineRenderLightTtlTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.Light.SequenceActionTimeLineRenderLightTtlTrack", 0, Black.Sequence.Action.TimeLine.Render.Light.SequenceActionTimeLineRenderLightTtlTrack.ObjectType, null, properties, 0, 400);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.Light.SequenceActionTimeLineRenderLightTtlTrack", base.GetFieldProperties(), -33155265, -336923074);
            return fieldProperties;
        }

		
    }
}