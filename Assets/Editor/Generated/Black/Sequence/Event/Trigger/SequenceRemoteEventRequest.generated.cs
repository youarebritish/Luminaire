using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Trigger
{
    public partial class SequenceRemoteEventRequest : SQEX.Ebony.Framework.Sequence.Control.SequenceControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public uint eventId_;
		public IList<SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveBase> arguments_;
		public bool printLog_;
		public int notifyRange_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceRemoteEventRequest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Trigger.SequenceRemoteEventRequest", 0, Black.Sequence.Event.Trigger.SequenceRemoteEventRequest.ObjectType, null, properties, 0, 400);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Trigger.SequenceRemoteEventRequest", base.GetFieldProperties(), -1295874165, -93443937);
            return fieldProperties;
        }

		
    }
}