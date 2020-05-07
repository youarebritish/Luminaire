using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Operator.Calculate
{
    public partial class SequenceOperatorStartSequenceCommand : Black.Sequence.Operator.SequenceOperatorCalculateBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin commandSet_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueOutPin_;
		public uint commandId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceOperatorStartSequenceCommand();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Operator.Calculate.SequenceOperatorStartSequenceCommand", 0, Black.Sequence.Operator.Calculate.SequenceOperatorStartSequenceCommand.ObjectType, null, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Operator.Calculate.SequenceOperatorStartSequenceCommand", base.GetFieldProperties(), -1108095261, -889774583);
            
			
			
			return fieldProperties;
        }

		
    }
}