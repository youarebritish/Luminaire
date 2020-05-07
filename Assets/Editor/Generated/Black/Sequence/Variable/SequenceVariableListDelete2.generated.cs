using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableListDelete2 : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin list_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin index_;
		public bool clearAll_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableListDelete2();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableListDelete2", 0, Black.Sequence.Variable.SequenceVariableListDelete2.ObjectType, null, properties, 0, 552);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableListDelete2", base.GetFieldProperties(), -528486785, -311384165);
            return fieldProperties;
        }

		
    }
}