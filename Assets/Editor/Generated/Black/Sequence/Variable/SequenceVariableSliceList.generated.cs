using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable
{
    public partial class SequenceVariableSliceList : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failure_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin listPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin startIndexPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin countPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin slicedListPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin otherListPin_;
		public int getIndex_;
		public int getCount_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableSliceList();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.SequenceVariableSliceList", 0, Black.Sequence.Variable.SequenceVariableSliceList.ObjectType, null, properties, 0, 968);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.SequenceVariableSliceList", base.GetFieldProperties(), 876417980, 968550807);
            return fieldProperties;
        }

		
    }
}