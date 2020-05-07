using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu
{
    public partial class SequenceSyncRemoteEventRequest : Black.Sequence.Event.Trigger.SequenceRemoteEventRequest
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool onlySendThis_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceSyncRemoteEventRequest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.SequenceSyncRemoteEventRequest", 0, Black.Sequence.Event.Menu.SequenceSyncRemoteEventRequest.ObjectType, null, properties, 0, 424);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.SequenceSyncRemoteEventRequest", base.GetFieldProperties(), 1106053038, -1300155558);
            return fieldProperties;
        }

		
    }
}