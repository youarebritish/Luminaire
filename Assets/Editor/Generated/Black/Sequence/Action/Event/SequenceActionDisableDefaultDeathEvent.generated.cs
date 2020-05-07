using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Event
{
    public partial class SequenceActionDisableDefaultDeathEvent : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enableInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disableInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDisableDefaultDeathEvent();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Event.SequenceActionDisableDefaultDeathEvent", 0, Black.Sequence.Action.Event.SequenceActionDisableDefaultDeathEvent.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Event.SequenceActionDisableDefaultDeathEvent", base.GetFieldProperties(), -1569090793, -1836688271);
            
			
			
			return fieldProperties;
        }

		
    }
}