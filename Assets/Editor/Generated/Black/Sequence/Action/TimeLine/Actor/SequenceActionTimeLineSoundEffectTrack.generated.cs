using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor
{
    public partial class SequenceActionTimeLineSoundEffectTrack : Black.Sequence.Action.TimeLine.Sound.SequenceActionTimeLineSoundTrackCommon
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint joint_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineSoundEffectTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineSoundEffectTrack", 0, Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineSoundEffectTrack.ObjectType, null, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineSoundEffectTrack", base.GetFieldProperties(), 812928735, 1141138821);
            return fieldProperties;
        }

		
    }
}