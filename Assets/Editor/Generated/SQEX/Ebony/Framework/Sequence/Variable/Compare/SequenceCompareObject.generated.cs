using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable.Compare
{
    public partial class SequenceCompareObject : SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceCompareObject();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareObject", 0, SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareObject.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareObject", base.GetFieldProperties(), 1756350935, 56637929);
            
			
			
			return fieldProperties;
        }

		
    }
}