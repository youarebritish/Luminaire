using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render.PostProcess
{
    public partial class SequenceActionTimeLineVWVignetteFilterTrack : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.Sequence.ScreenEffect.VWVignetteFilterSequenceData masterData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineVWVignetteFilterTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineVWVignetteFilterTrack", 0, Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineVWVignetteFilterTrack.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineVWVignetteFilterTrack", base.GetFieldProperties(), 689682697, 1730605999);
            return fieldProperties;
        }

		
    }
}