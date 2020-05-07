using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable.AI
{
    public partial class SequenceVariableAITaskProperty : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outputPin_;
		public uint propertyId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableAITaskProperty();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.AI.SequenceVariableAITaskProperty", 0, Black.Sequence.Variable.AI.SequenceVariableAITaskProperty.ObjectType, null, properties, 0, 280);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.AI.SequenceVariableAITaskProperty", base.GetFieldProperties(), 1702198440, 1091620802);
            return fieldProperties;
        }

		
    }
}