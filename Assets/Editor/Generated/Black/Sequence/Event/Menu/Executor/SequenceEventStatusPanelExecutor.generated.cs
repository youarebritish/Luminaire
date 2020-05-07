using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventStatusPanelExecutor : Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float hpGaugeSpeedRate_;
		public int hpGaugeRecoveryDelayFrame_;
		public int offsetX_;
		public int offsetY_;
		public int offsetHeight_;
		public int offsetMiminumHpX_;
		public int offsetMaxMpX_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventStatusPanelExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventStatusPanelExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventStatusPanelExecutor.ObjectType, null, properties, 0, 1872);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventStatusPanelExecutor", base.GetFieldProperties(), -21546483, -1789475559);
            
			
			
			return fieldProperties;
        }

		
    }
}