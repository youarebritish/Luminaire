using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Data.PropertyData.LightProperty
{
    public partial class LightPropertyBool : SQEX.Ebony.AIGraph.Data.PropertyData.LightProperty.LightPropertyPrimitiveBase
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

            var dummy = new LightPropertyBool();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Data.PropertyData.LightProperty.LightPropertyBool", 0, SQEX.Ebony.AIGraph.Data.PropertyData.LightProperty.LightPropertyBool.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Data.PropertyData.LightProperty.LightPropertyBool", base.GetFieldProperties(), 560919828, -1273980357);
            
			
			
			return fieldProperties;
        }

		
    }
}