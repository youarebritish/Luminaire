using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event
{
    public partial class SequenceEventOnNetworkDisconnected : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outByService_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outByUser_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outBySocketError_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventOnNetworkDisconnected();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.SequenceEventOnNetworkDisconnected", 0, Black.Sequence.Event.SequenceEventOnNetworkDisconnected.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.SequenceEventOnNetworkDisconnected", base.GetFieldProperties(), -1560982834, 1480100229);
            
			
			
			return fieldProperties;
        }

		
    }
}