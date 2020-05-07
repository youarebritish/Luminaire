using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.ScreenEffect
{
    public partial class VWGlareFilterSequenceData : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public bool enableWeather_;
		public float gammaSpace_;
		public float softAmount_;
		public float softExpand_;
		public float foggyAmount_;
		public float foggyExpand_;
		public bool useColoring_;
		public float soft_r_;
		public float soft_g_;
		public float soft_b_;
		public float foggy_r_;
		public float foggy_g_;
		public float foggy_b_;
		public float sparkBlend_;
		public float sparkAttenuation_;
		public int sparkShape_;
		public float sparkRotation_;
		public bool useSparkColoring_;
		public float spark_r_;
		public float spark_g_;
		public float spark_b_;
		public bool debugGraph_;
		public int debugIndex_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VWGlareFilterSequenceData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.ScreenEffect.VWGlareFilterSequenceData", 0, Black.Sequence.ScreenEffect.VWGlareFilterSequenceData.ObjectType, null, properties, 0, 104);
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

            fieldProperties = new PropertyContainer("Black.Sequence.ScreenEffect.VWGlareFilterSequenceData", base.GetFieldProperties(), 2008622319, -20028584);
            
			
			
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 8, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("enableWeather_", 1384777099, "bool", 9, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("gammaSpace_", 1317534113, "float", 12, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("softAmount_", 3492105266, "float", 16, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("softExpand_", 2330475754, "float", 20, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("foggyAmount_", 1144260616, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("foggyExpand_", 417718684, "float", 28, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("useColoring_", 1428224166, "bool", 32, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("soft_r_", 655107457, "float", 36, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("soft_g_", 1730993644, "float", 40, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("soft_b_", 1731434929, "float", 44, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("foggy_r_", 998115543, "float", 48, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("foggy_g_", 1000234114, "float", 52, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("foggy_b_", 1000778567, "float", 56, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("sparkBlend_", 1131517066, "float", 60, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("sparkAttenuation_", 653011911, "float", 64, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("sparkShape_", 1773800168, "int", 68, 4, 1, Property.PrimitiveType.Int32, 0, (char)1));
			fieldProperties.AddProperty(new Property("sparkRotation_", 2836768453, "float", 72, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("useSparkColoring_", 4142377497, "bool", 76, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("spark_r_", 1188696936, "float", 80, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("spark_g_", 111530821, "float", 84, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("spark_b_", 1186033912, "float", 88, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("debugGraph_", 2119714841, "bool", 92, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("debugIndex_", 2056283633, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)1));
			
			
			return fieldProperties;
        }

		
    }
}