using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Event
{
    public partial class SequenceActionEventPriorityRequest : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startCheck_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reserve_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin cancel_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin timeoutSecPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin eventIDPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin startOK_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin startNG_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reserveStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reserveEnd_;
		public uint eventID_;
		public float timeoutSec_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionEventPriorityRequest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Event.SequenceActionEventPriorityRequest", 0, Black.Sequence.Action.Event.SequenceActionEventPriorityRequest.ObjectType, null, properties, 0, 1136);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Event.SequenceActionEventPriorityRequest", base.GetFieldProperties(), -1432880960, 106962284);
            
			
			
			return fieldProperties;
        }

		
    }
}