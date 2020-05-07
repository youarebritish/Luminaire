using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Event
{
    public partial class SequenceEventWorldTimerUpdated : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int wakeUpTimeType_;
		public int hour_;
		public int minute_;
		public int second_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventWorldTimerUpdated();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Event.SequenceEventWorldTimerUpdated", 0, SQEX.Ebony.Framework.Sequence.Event.SequenceEventWorldTimerUpdated.ObjectType, null, properties, 0, 296);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Event.SequenceEventWorldTimerUpdated", base.GetFieldProperties(), 2078042126, 379598608);
            return fieldProperties;
        }

		
    }
}