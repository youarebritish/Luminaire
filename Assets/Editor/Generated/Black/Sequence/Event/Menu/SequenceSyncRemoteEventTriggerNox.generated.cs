using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu
{
    public partial class SequenceSyncRemoteEventTriggerNox : Black.Sequence.Event.Trigger.SequenceRemoteEventTrigger
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enablePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disablePin_;
		public bool autoDisable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceSyncRemoteEventTriggerNox();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.SequenceSyncRemoteEventTriggerNox", 0, Black.Sequence.Event.Menu.SequenceSyncRemoteEventTriggerNox.ObjectType, null, properties, 0, 520);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.SequenceSyncRemoteEventTriggerNox", base.GetFieldProperties(), 1333686488, 1265482111);
            return fieldProperties;
        }

		
    }
}