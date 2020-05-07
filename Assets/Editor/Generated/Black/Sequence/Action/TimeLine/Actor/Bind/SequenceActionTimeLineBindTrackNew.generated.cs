using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor.Bind
{
    public partial class SequenceActionTimeLineBindTrackNew : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int filterLevel_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineBindTrackNew();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.Bind.SequenceActionTimeLineBindTrackNew", 0, Black.Sequence.Action.TimeLine.Actor.Bind.SequenceActionTimeLineBindTrackNew.ObjectType, null, properties, 0, 408);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.Bind.SequenceActionTimeLineBindTrackNew", base.GetFieldProperties(), -90308278, 1586244729);
            return fieldProperties;
        }

		
    }
}