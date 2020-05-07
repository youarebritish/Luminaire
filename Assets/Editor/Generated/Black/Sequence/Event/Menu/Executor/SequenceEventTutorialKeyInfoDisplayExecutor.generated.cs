using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventTutorialKeyInfoDisplayExecutor : Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventTutorialKeyInfoDisplayExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventTutorialKeyInfoDisplayExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventTutorialKeyInfoDisplayExecutor.ObjectType, null, properties, 0, 1104);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventTutorialKeyInfoDisplayExecutor", base.GetFieldProperties(), 1435723118, -859421735);
            return fieldProperties;
        }

		
    }
}