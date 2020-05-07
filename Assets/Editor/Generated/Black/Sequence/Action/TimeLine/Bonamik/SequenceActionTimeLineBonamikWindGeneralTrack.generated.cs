using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Bonamik
{
    public partial class SequenceActionTimeLineBonamikWindGeneralTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineBonamikWindGeneralTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Bonamik.SequenceActionTimeLineBonamikWindGeneralTrack", 0, Black.Sequence.Action.TimeLine.Bonamik.SequenceActionTimeLineBonamikWindGeneralTrack.ObjectType, null, properties, 0, 400);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Bonamik.SequenceActionTimeLineBonamikWindGeneralTrack", base.GetFieldProperties(), -1809014432, -1499655907);
            return fieldProperties;
        }

		
    }
}