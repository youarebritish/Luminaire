using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableList : SQEX.Ebony.Framework.Sequence.SequenceVariable
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin addAllInList_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin addElement_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin resetAndAddAll_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin getContainer_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin listObjNum_;
		public bool bIsClear_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableList();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableList", 0, Black.Sequence.Variable.SequenceVariableList.ObjectType, null, properties, 0, 584);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableList", base.GetFieldProperties(), 114184803, 1684569490);
            return fieldProperties;
        }

		
    }
}