using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu
{
    public partial class SequenceEventCombatCommandMenuClosed : Black.Sequence.Event.Menu.SequenceEventUiBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventCombatCommandMenuClosed();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.SequenceEventCombatCommandMenuClosed", 0, Black.Sequence.Event.Menu.SequenceEventCombatCommandMenuClosed.ObjectType, null, properties, 0, 296);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.SequenceEventCombatCommandMenuClosed", base.GetFieldProperties(), 419051545, -100312437);
            return fieldProperties;
        }

		
    }
}