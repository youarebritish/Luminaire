using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.General
{
    public partial class SequenceActionTimeLineSoundTrackGeneral : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineSoundTrackGeneral();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.General.SequenceActionTimeLineSoundTrackGeneral", 0, Black.Sequence.Action.TimeLine.General.SequenceActionTimeLineSoundTrackGeneral.ObjectType, null, properties, 0, 408);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.General.SequenceActionTimeLineSoundTrackGeneral", base.GetFieldProperties(), 223281743, -1422047422);
            
			
			
			return fieldProperties;
        }

		
    }
}