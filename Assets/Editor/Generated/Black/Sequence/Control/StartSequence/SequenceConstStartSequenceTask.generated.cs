using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control.StartSequence
{
    public partial class SequenceConstStartSequenceTask : SQEX.Ebony.Framework.Sequence.Variable.SequenceConstBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor2Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin int1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin commandSetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin taskOutPin_;
		public uint taskId_;
		public uint functionId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConstStartSequenceTask();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.StartSequence.SequenceConstStartSequenceTask", 0, Black.Sequence.Control.StartSequence.SequenceConstStartSequenceTask.ObjectType, null, properties, 0, 536);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.StartSequence.SequenceConstStartSequenceTask", base.GetFieldProperties(), -2000531206, -1723916914);
            
			
			
			return fieldProperties;
        }

		
    }
}