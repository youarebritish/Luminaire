using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.General
{
    public partial class SequenceActionTimeLineSoundEffectTrackGeneral : Black.Sequence.Action.TimeLine.Sound.SequenceActionTimeLineSoundTrackCommon
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float zeroone_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineSoundEffectTrackGeneral();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.General.SequenceActionTimeLineSoundEffectTrackGeneral", 0, Black.Sequence.Action.TimeLine.General.SequenceActionTimeLineSoundEffectTrackGeneral.ObjectType, null, properties, 0, 440);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.General.SequenceActionTimeLineSoundEffectTrackGeneral", base.GetFieldProperties(), -388714654, 288349309);
            return fieldProperties;
        }

		
    }
}