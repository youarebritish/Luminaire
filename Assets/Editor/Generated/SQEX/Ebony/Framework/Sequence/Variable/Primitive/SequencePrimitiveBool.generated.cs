using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable.Primitive
{
    public partial class SequencePrimitiveBool : SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequencePrimitiveBool();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveBool", 0, SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveBool.ObjectType, null, properties, 0, 80);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveBool", base.GetFieldProperties(), 256269532, 858223952);
            return fieldProperties;
        }

		
    }
}