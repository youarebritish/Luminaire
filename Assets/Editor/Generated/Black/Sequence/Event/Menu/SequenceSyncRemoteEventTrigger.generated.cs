using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu
{
    public partial class SequenceSyncRemoteEventTrigger : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enablePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disablePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin wakeUpPin_;
		public uint eventId_;
		public bool autoDisable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceSyncRemoteEventTrigger();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.SequenceSyncRemoteEventTrigger", 0, Black.Sequence.Event.Menu.SequenceSyncRemoteEventTrigger.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.SequenceSyncRemoteEventTrigger", base.GetFieldProperties(), 1455490687, -663958331);
            
			
			
			return fieldProperties;
        }

		
    }
}