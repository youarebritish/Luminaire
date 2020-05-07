using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventShopMenuExecutor : Black.Sequence.Event.Menu.SequenceEventUiEntityInputBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventShopMenuExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventShopMenuExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventShopMenuExecutor.ObjectType, null, properties, 0, 1144);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventShopMenuExecutor", base.GetFieldProperties(), 1581493075, -1315894428);
            return fieldProperties;
        }

		
    }
}