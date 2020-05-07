using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable.Labeled
{
    public partial class SequenceListVariableLabeledFixId : Black.Sequence.Variable.Labeled.SequenceVariableLabeledFixIdBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin addAllInList_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin addElement_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin getContainer_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin listObjNum_;
		public bool bIsClear_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceListVariableLabeledFixId();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.Labeled.SequenceListVariableLabeledFixId", 0, Black.Sequence.Variable.Labeled.SequenceListVariableLabeledFixId.ObjectType, null, properties, 0, 496);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.Labeled.SequenceListVariableLabeledFixId", base.GetFieldProperties(), 961203808, 979317615);
            
			
			
			return fieldProperties;
        }

		
    }
}