using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable.Primitive
{
    public partial class SequencePrimitiveObject : SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequencePrimitiveObject();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveObject", 0, SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveObject.ObjectType, null, properties, 0, 72);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveObject", base.GetFieldProperties(), -693651365, 774745589);
            return fieldProperties;
        }

		
    }
}