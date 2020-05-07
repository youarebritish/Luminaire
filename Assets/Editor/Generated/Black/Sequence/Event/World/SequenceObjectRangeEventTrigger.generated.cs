using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.World
{
    public partial class SequenceObjectRangeEventTrigger : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin enter_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin leave_;
		public bool checkPrecise_;
		public float checkRange_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceObjectRangeEventTrigger();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.World.SequenceObjectRangeEventTrigger", 0, Black.Sequence.Event.World.SequenceObjectRangeEventTrigger.ObjectType, null, properties, 0, 592);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.World.SequenceObjectRangeEventTrigger", base.GetFieldProperties(), 1677478524, 1752794828);
            return fieldProperties;
        }

		
    }
}