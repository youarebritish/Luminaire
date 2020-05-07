using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Data.PropertyData.LightProperty
{
    public partial class LightPropertyFloat : SQEX.Ebony.AIGraph.Data.PropertyData.LightProperty.LightPropertyPrimitiveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LightPropertyFloat();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Data.PropertyData.LightProperty.LightPropertyFloat", 0, SQEX.Ebony.AIGraph.Data.PropertyData.LightProperty.LightPropertyFloat.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Data.PropertyData.LightProperty.LightPropertyFloat", base.GetFieldProperties(), -1641990589, -587546967);
            return fieldProperties;
        }

		
    }
}