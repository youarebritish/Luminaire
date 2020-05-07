using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Bonamik
{
    public partial class SequenceActionTimeLineBonamikControlActorTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineBonamikControlActorTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Bonamik.SequenceActionTimeLineBonamikControlActorTrack", 0, Black.Sequence.Action.TimeLine.Bonamik.SequenceActionTimeLineBonamikControlActorTrack.ObjectType, null, properties, 0, 344);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Bonamik.SequenceActionTimeLineBonamikControlActorTrack", base.GetFieldProperties(), -589532759, -1288724911);
            
			
			
			return fieldProperties;
        }

		
    }
}