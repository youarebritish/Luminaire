using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable.Labeled
{
    public partial class SequenceVariableLabeledFixIdBase : Black.Sequence.Variable.Labeled.SequenceVariableLabeledCommonBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint label_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableLabeledFixIdBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.Labeled.SequenceVariableLabeledFixIdBase", 0, Black.Sequence.Variable.Labeled.SequenceVariableLabeledFixIdBase.ObjectType, null, properties, 0, 136);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.Labeled.SequenceVariableLabeledFixIdBase", base.GetFieldProperties(), -1780176326, -355773798);
            return fieldProperties;
        }

		
    }
}