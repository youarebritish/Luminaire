using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render.Environment
{
    public partial class SequenceActionTimeLineFoliageLODScaleTrack : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.System.TimeLine.TrackItem.Render.Environment.Struct.InGameFoliageLODScale lodScaleData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineFoliageLODScaleTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.Environment.SequenceActionTimeLineFoliageLODScaleTrack", 0, Black.Sequence.Action.TimeLine.Render.Environment.SequenceActionTimeLineFoliageLODScaleTrack.ObjectType, null, properties, 0, 336);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.Environment.SequenceActionTimeLineFoliageLODScaleTrack", base.GetFieldProperties(), 1705621267, -321974600);
            
			
			
			return fieldProperties;
        }

		
    }
}