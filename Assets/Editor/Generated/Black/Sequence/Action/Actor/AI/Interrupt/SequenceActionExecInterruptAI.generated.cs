using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.AI.Interrupt
{
    public partial class SequenceActionExecInterruptAI : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin error_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inProperties_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inTaskId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inFilePath_;
		public string filePath_;
		public uint taskId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionExecInterruptAI();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.AI.Interrupt.SequenceActionExecInterruptAI", 0, Black.Sequence.Action.Actor.AI.Interrupt.SequenceActionExecInterruptAI.ObjectType, null, properties, 0, 880);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.AI.Interrupt.SequenceActionExecInterruptAI", base.GetFieldProperties(), -422483436, -261322865);
            return fieldProperties;
        }

		
    }
}