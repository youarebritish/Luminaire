using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Trigger
{
    public partial class SequenceRemoteEventTrigger : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin wakeUpPin_;
		public uint eventId_;
		public IList<SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveBase> arguments_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceRemoteEventTrigger();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Trigger.SequenceRemoteEventTrigger", 0, Black.Sequence.Event.Trigger.SequenceRemoteEventTrigger.ObjectType, null, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Trigger.SequenceRemoteEventTrigger", base.GetFieldProperties(), 18218225, -1579272896);
            
			
			
			return fieldProperties;
        }

		
    }
}