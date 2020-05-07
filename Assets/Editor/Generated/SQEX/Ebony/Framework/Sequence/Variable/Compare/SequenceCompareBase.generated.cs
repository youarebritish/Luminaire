using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable.Compare
{
    public partial class SequenceCompareBase : SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveBaseCommon
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int operator_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceCompareBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareBase", 0, SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareBase.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareBase", base.GetFieldProperties(), 531181625, -929298747);
            
			fieldProperties.AddIndirectlyProperty(new Property("pDependencyPin_", 1541179946, "void", 8, 8, 1, Property.PrimitiveType.Pointer, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("operator_", 305375494, "SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareBase.OperatorType", 24, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}