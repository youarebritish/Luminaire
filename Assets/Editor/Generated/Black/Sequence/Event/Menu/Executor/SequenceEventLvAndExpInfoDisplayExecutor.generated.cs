using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventLvAndExpInfoDisplayExecutor : Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float idleTime_;
		public float offsetHeight_;
		public float offsetX_;
		public float offsetY_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventLvAndExpInfoDisplayExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventLvAndExpInfoDisplayExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventLvAndExpInfoDisplayExecutor.ObjectType, null, properties, 0, 1112);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventLvAndExpInfoDisplayExecutor", base.GetFieldProperties(), -1107798099, 819515526);
            return fieldProperties;
        }

		
    }
}