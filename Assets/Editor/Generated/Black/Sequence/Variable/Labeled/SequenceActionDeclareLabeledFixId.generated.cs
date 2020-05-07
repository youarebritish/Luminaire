using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable.Labeled
{
    public partial class SequenceActionDeclareLabeledFixId : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int labelScope_;
		public IList<Black.Sequence.Variable.Labeled.Struct.LabeledVariableData> data_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDeclareLabeledFixId();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.Labeled.SequenceActionDeclareLabeledFixId", 0, Black.Sequence.Variable.Labeled.SequenceActionDeclareLabeledFixId.ObjectType, null, properties, 0, 408);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.Labeled.SequenceActionDeclareLabeledFixId", base.GetFieldProperties(), 811360324, -486480667);
            
			
			
			return fieldProperties;
        }

		
    }
}