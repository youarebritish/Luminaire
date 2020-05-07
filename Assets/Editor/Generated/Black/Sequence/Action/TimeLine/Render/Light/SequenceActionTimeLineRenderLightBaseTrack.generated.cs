using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render.Light
{
    public partial class SequenceActionTimeLineRenderLightBaseTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool intensityFlag_;
		public bool radiusFlag_;
		public bool rangeFlag_;
		public bool shadowResolutionFlag_;
		public bool shadowZNearFlag_;
		public bool shadowSlopeBiasFlag_;
		public bool shadowZBiasFlag_;
		public bool shadowPowerFlag_;
		public Black.System.TimeLine.TrackItem.Render.Light.LightBaseTrackItem masterTrackItem_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineRenderLightBaseTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.Light.SequenceActionTimeLineRenderLightBaseTrack", 0, Black.Sequence.Action.TimeLine.Render.Light.SequenceActionTimeLineRenderLightBaseTrack.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.Light.SequenceActionTimeLineRenderLightBaseTrack", base.GetFieldProperties(), -1443537066, -997980498);
            
			
			
			return fieldProperties;
        }

		
    }
}