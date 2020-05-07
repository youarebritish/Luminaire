using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventEnemyHPBarExecutor : Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int maxCount_;
		public float displayTime_;
		public float offsetX_;
		public float offsetY_;
		public float damageGaugeSpeedRatio_;
		public float finishTime_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventEnemyHPBarExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventEnemyHPBarExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventEnemyHPBarExecutor.ObjectType, null, properties, 0, 1184);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventEnemyHPBarExecutor", base.GetFieldProperties(), 1959069515, -1156144885);
            
			
			
			return fieldProperties;
        }

		
    }
}