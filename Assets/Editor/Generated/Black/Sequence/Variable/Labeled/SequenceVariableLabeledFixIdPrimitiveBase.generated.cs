using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Variable.Labeled
{
    public partial class SequenceVariableLabeledFixIdPrimitiveBase : Black.Sequence.Variable.Labeled.SequenceVariableLabeledFixIdBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceVariableLabeledFixIdPrimitiveBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Variable.Labeled.SequenceVariableLabeledFixIdPrimitiveBase", 0, Black.Sequence.Variable.Labeled.SequenceVariableLabeledFixIdPrimitiveBase.ObjectType, null, properties, 0, 224);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Variable.Labeled.SequenceVariableLabeledFixIdPrimitiveBase", base.GetFieldProperties(), 564452132, 1144617378);
            return fieldProperties;
        }

		
    }
}