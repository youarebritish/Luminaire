using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable.Primitive
{
    public partial class SequencePrimitiveString : SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequencePrimitiveString();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveString", 0, SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveString.ObjectType, null, properties, 0, 88);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveString", base.GetFieldProperties(), 886743486, -995906222);
            
			
			
			return fieldProperties;
        }

		
    }
}