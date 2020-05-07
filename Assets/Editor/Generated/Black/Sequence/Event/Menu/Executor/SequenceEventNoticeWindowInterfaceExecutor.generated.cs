using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu.Executor
{
    public partial class SequenceEventNoticeWindowInterfaceExecutor : Black.Sequence.Event.Menu.SequenceEventUiBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint areaId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin pitEnqueInfo;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventNoticeWindowInterfaceExecutor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.Executor.SequenceEventNoticeWindowInterfaceExecutor", 0, Black.Sequence.Event.Menu.Executor.SequenceEventNoticeWindowInterfaceExecutor.ObjectType, null, properties, 0, 400);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.Executor.SequenceEventNoticeWindowInterfaceExecutor", base.GetFieldProperties(), -431226100, 1186973012);
            
			
			
			return fieldProperties;
        }

		
    }
}