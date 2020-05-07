using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Menu
{
    public partial class SequenceEventPartyActorListChanged : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin partyActorListPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventPartyActorListChanged();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Menu.SequenceEventPartyActorListChanged", 0, Black.Sequence.Event.Menu.SequenceEventPartyActorListChanged.ObjectType, null, properties, 0, 408);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Menu.SequenceEventPartyActorListChanged", base.GetFieldProperties(), 352209020, 1668361046);
            return fieldProperties;
        }

		
    }
}