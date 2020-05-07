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
            
			fieldProperties.AddProperty(new Property("hpGaugeSpeedRate_", 2536172762, "float", 1088, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("hpGaugeRecoveryDelayFrame_", 2673390744, "int", 1092, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetX_", 1096147371, "int", 1096, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetY_", 2170062082, "int", 1100, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetHeight_", 923942338, "int", 1104, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetMiminumHpX_", 1154327679, "int", 1108, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("offsetMaxMpX_", 1730320372, "int", 1112, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}