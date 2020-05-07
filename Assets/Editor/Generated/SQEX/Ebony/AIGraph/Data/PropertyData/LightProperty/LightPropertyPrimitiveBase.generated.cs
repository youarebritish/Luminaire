using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Data.PropertyData.LightProperty
{
    public partial class LightPropertyPrimitiveBase : SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LightPropertyPrimitiveBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Data.PropertyData.LightProperty.LightPropertyPrimitiveBase", 0, SQEX.Ebony.AIGraph.Data.PropertyData.LightProperty.LightPropertyPrimitiveBase.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Data.PropertyData.LightProperty.LightPropertyPrimitiveBase", base.GetFieldProperties(), 2147455658, -989594745);
            return fieldProperties;
        }

		
    }
}