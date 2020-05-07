using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data
{
    public partial class WeatherData2Entity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string weatherFilePath_;
		public float weatherTransitionTime_;
		public uint defaultClimateId_;
		public string weatherKey_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new WeatherData2Entity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.WeatherData2Entity", 0, Black.Entity.Data.WeatherData2Entity.ObjectType, null, properties, 0, 120);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.WeatherData2Entity", base.GetFieldProperties(), 864614679, 1804167017);
            
			fieldProperties.AddProperty(new Property("weatherFilePath_", 3107336195, "SQEX.Ebony.Base.String", 64, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("weatherTransitionTime_", 4249573478, "float", 80, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("defaultClimateId_", 1751479349, "SQEX.Ebony.Std.Fixid", 84, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("weatherKey_", 1274001839, "SQEX.Ebony.Base.String", 88, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}