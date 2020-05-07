using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine
{
    public partial class SequenceActionTimeLineSoundOptionTrackGeneral : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string category_;
		public float volume_;
		public bool bDefaultChangable_;
		public float defaultOverrideVolume_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineSoundOptionTrackGeneral();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.SequenceActionTimeLineSoundOptionTrackGeneral", 0, Black.Sequence.Action.TimeLine.SequenceActionTimeLineSoundOptionTrackGeneral.ObjectType, null, properties, 0, 440);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.SequenceActionTimeLineSoundOptionTrackGeneral", base.GetFieldProperties(), 363244633, -575370771);
            return fieldProperties;
        }

		
    }
}