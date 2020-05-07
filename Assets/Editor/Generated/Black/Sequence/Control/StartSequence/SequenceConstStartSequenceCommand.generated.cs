using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control.StartSequence
{
    public partial class SequenceConstStartSequenceCommand : SQEX.Ebony.Framework.Sequence.Variable.SequenceConstBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin commandPin_;
		public uint commandId_;
		public float value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConstStartSequenceCommand();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.StartSequence.SequenceConstStartSequenceCommand", 0, Black.Sequence.Control.StartSequence.SequenceConstStartSequenceCommand.ObjectType, null, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.StartSequence.SequenceConstStartSequenceCommand", base.GetFieldProperties(), -1222941898, 1335775209);
            
			
			
			return fieldProperties;
        }

		
    }
}