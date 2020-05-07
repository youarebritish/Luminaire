using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Bonamik
{
    public partial class SequenceActionTimeLineBonamikControlActorRangeTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineBonamikControlActorRangeTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Bonamik.SequenceActionTimeLineBonamikControlActorRangeTrack", 0, Black.Sequence.Action.TimeLine.Bonamik.SequenceActionTimeLineBonamikControlActorRangeTrack.ObjectType, null, properties, 0, 400);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Bonamik.SequenceActionTimeLineBonamikControlActorRangeTrack", base.GetFieldProperties(), 973061224, 194457084);
            return fieldProperties;
        }

		
    }
}