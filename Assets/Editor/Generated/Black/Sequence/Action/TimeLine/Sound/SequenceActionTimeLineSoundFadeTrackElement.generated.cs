using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Sound
{
    public partial class SequenceActionTimeLineSoundFadeTrackElement : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineSoundFadeTrackElement();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Sound.SequenceActionTimeLineSoundFadeTrackElement", 0, Black.Sequence.Action.TimeLine.Sound.SequenceActionTimeLineSoundFadeTrackElement.ObjectType, null, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Sound.SequenceActionTimeLineSoundFadeTrackElement", base.GetFieldProperties(), 38957618, -1535299686);
            return fieldProperties;
        }

		
    }
}