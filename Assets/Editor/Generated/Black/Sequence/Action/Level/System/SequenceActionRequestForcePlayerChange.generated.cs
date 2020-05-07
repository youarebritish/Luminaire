using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.System
{
    public partial class SequenceActionRequestForcePlayerChange : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin startedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin characterNoPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin eventTypeNoPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cameraIDPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isRequestedPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionRequestForcePlayerChange();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.System.SequenceActionRequestForcePlayerChange", 0, Black.Sequence.Action.Level.System.SequenceActionRequestForcePlayerChange.ObjectType, null, properties, 0, 920);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.System.SequenceActionRequestForcePlayerChange", base.GetFieldProperties(), 454251644, 1521118083);
            
			
			
			return fieldProperties;
        }

		
    }
}