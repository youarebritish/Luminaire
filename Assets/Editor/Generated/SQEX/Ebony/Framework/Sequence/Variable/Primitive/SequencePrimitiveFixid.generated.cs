using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable.Primitive
{
    public partial class SequencePrimitiveFixid : SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequencePrimitiveFixid();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveFixid", 0, SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveFixid.ObjectType, null, properties, 0, 88);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequencePrimitiveFixid", base.GetFieldProperties(), -523969553, -1785725128);
            return fieldProperties;
        }

		
    }
}