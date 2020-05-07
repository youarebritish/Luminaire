using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceListVariableLabeled : Black.Sequence.Variable.SequenceVariableLabeledStringBase
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

            var dummy = new SequenceListVariableLabeled();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceListVariableLabeled", 0, Black.Sequence.Variable.SequenceListVariableLabeled.ObjectType, null, properties, 0, 520);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceListVariableLabeled", base.GetFieldProperties(), 628156928, 941875169);
            
			
			
			return fieldProperties;
        }

		
    }
}