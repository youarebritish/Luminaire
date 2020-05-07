using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor
{
    public partial class SequenceActionTimeLineMovementTrackElementPositionYCurve : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineMovementTrackElementPositionYCurve();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineMovementTrackElementPositionYCurve", 0, Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineMovementTrackElementPositionYCurve.ObjectType, null, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.SequenceActionTimeLineMovementTrackElementPositionYCurve", base.GetFieldProperties(), 963220211, -274434882);
            return fieldProperties;
        }

		
    }
}