using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Event
{
    public partial class SequenceEventFrameUpdated : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		public bool isEnabled_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventFrameUpdated();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Event.SequenceEventFrameUpdated", 0, SQEX.Ebony.Framework.Sequence.Event.SequenceEventFrameUpdated.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Event.SequenceEventFrameUpdated", base.GetFieldProperties(), 106632703, -172064590);
            return fieldProperties;
        }

		
    }
}