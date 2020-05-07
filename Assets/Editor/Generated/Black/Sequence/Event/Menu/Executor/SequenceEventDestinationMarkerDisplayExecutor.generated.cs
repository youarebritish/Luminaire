using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventDestinationMarkerDisplayExecutor : Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int paramPixOffsetDef_;
		public int paramMarkerMax_;
		public int distanceMin_;
		public int distanceMax_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventDestinationMarkerDisplayExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventDestinationMarkerDisplayExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventDestinationMarkerDisplayExecutor.ObjectType, null, properties, 0, 1120);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventDestinationMarkerDisplayExecutor", base.GetFieldProperties(), -339235121, 1678102769);
            return fieldProperties;
        }

		
    }
}