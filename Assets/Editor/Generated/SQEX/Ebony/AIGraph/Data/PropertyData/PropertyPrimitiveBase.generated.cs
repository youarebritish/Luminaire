using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Data.PropertyData
{
    public partial class PropertyPrimitiveBase : SQEX.Ebony.AIGraph.Data.PropertyData.LinkPropertyBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PropertyPrimitiveBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Data.PropertyData.PropertyPrimitiveBase", 0, SQEX.Ebony.AIGraph.Data.PropertyData.PropertyPrimitiveBase.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Data.PropertyData.PropertyPrimitiveBase", base.GetFieldProperties(), -1950126957, 1716691662);
            return fieldProperties;
        }

		
    }
}