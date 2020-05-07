using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.System
{
    public partial class SequenceActionTimeLinePadVibrationTrack : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin receiverActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sourceActorPin_;
		public int vibrationLevel_;
		public float powerLo_;
		public float powerHi_;
		public float undampedDistance_;
		public float endAttenuationDistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLinePadVibrationTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.System.SequenceActionTimeLinePadVibrationTrack", 0, Black.Sequence.Action.TimeLine.System.SequenceActionTimeLinePadVibrationTrack.ObjectType, null, properties, 0, 552);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.System.SequenceActionTimeLinePadVibrationTrack", base.GetFieldProperties(), 847056273, -2121389008);
            return fieldProperties;
        }

		
    }
}