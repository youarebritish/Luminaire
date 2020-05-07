using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine
{
    public partial class SequenceActionTimeLineGeneralSlowTrack : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int taskTimeRateLevel_;
		public float timeRate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineGeneralSlowTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.SequenceActionTimeLineGeneralSlowTrack", 0, Black.Sequence.Action.TimeLine.SequenceActionTimeLineGeneralSlowTrack.ObjectType, null, properties, 0, 328);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.SequenceActionTimeLineGeneralSlowTrack", base.GetFieldProperties(), 457849602, -1948405690);
            return fieldProperties;
        }

		
    }
}