using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable.Compare
{
    public partial class SequenceCompareString : SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareBase
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

            var dummy = new SequenceCompareString();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareString", 0, SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareString.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareString", base.GetFieldProperties(), 18837802, 1379874736);
            
			
			
			return fieldProperties;
        }

		
    }
}