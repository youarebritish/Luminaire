using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Variable.Compare
{
    public partial class SequenceCompareCollectionFloat : SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareCollectionBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareFloat> conditions_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceCompareCollectionFloat();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareCollectionFloat", 0, SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareCollectionFloat.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Variable.Compare.SequenceCompareCollectionFloat", base.GetFieldProperties(), 1917000028, -157727232);
            
			
			
			return fieldProperties;
        }

		
    }
}