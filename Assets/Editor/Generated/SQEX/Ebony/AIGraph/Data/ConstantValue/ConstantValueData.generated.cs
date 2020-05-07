using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Data.ConstantValue
{
    public partial class ConstantValueData : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.AIGraph.Data.ConstantValue.ConstantValueBase> values_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ConstantValueData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Data.ConstantValue.ConstantValueData", 0, SQEX.Ebony.AIGraph.Data.ConstantValue.ConstantValueData.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Data.ConstantValue.ConstantValueData", base.GetFieldProperties(), -1383737248, 319549414);
            return fieldProperties;
        }

		
    }
}