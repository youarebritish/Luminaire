using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventTacticalAbilityExecutor : Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float tacticalTextDisplayTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventTacticalAbilityExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventTacticalAbilityExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventTacticalAbilityExecutor.ObjectType, null, properties, 0, 1104);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventTacticalAbilityExecutor", base.GetFieldProperties(), -1788553635, 313286807);
            return fieldProperties;
        }

		
    }
}