using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine
{
    public partial class SequenceActionTimeLineActorVFXTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineLmVFXTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineActorVFXTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorVFXTrack", 0, Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorVFXTrack.ObjectType, null, properties, 0, 424);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorVFXTrack", base.GetFieldProperties(), 34345441, -288201142);
            return fieldProperties;
        }

		
    }
}