using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.AIMode
{
    public partial class SequenceActionExecAIModeRideOnTurret : Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecAIModeRideOnTurret();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeRideOnTurret", 0, Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeRideOnTurret.ObjectType, null, properties, 0, 1224);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.AIMode.SequenceActionExecAIModeRideOnTurret", base.GetFieldProperties(), 521288689, 1072432612);
            return fieldProperties;
        }

		
    }
}