using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.ScreenEffect
{
    public partial class SequenceActionSetVWGlare : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
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
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enabled_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin softAmount_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin softExpand_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foggyAmount_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foggyExpand_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin useColoring_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin soft_r_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin soft_g_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin soft_b_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foggy_r_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foggy_g_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foggy_b_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sparkBlend_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sparkAttenuation_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sparkShape_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sparkRotation_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin useSparkColoring_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spark_r_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spark_g_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spark_b_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVWGlare();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.ScreenEffect.SequenceActionSetVWGlare", 0, Black.Sequence.ScreenEffect.SequenceActionSetVWGlare.ObjectType, null, properties, 0, 2312);
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

            fieldProperties = new PropertyContainer("Black.Sequence.ScreenEffect.SequenceActionSetVWGlare", base.GetFieldProperties(), 1921943561, -421546516);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableWeather_", 1384777099, "bool", 369, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("gammaSpace_", 1317534113, "float", 372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("softAmount_", 3492105266, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("softExpand_", 2330475754, "float", 380, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("foggyAmount_", 1144260616, "float", 384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("foggyExpand_", 417718684, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("useColoring_", 1428224166, "bool", 392, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("soft_r_", 655107457, "float", 396, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("soft_g_", 1730993644, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("soft_b_", 1731434929, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("foggy_r_", 998115543, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("foggy_g_", 1000234114, "float", 412, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("foggy_b_", 1000778567, "float", 416, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sparkBlend_", 1131517066, "float", 420, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sparkAttenuation_", 653011911, "float", 424, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("sparkShape_", 1773800168, "int", 428, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("sparkRotation_", 2836768453, "float", 432, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("useSparkColoring_", 4142377497, "bool", 436, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("spark_r_", 1188696936, "float", 440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("spark_g_", 111530821, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("spark_b_", 1186033912, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("debugGraph_", 2119714841, "bool", 452, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("debugIndex_", 2056283633, "int", 456, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_pin_", 3058841247, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("softAmount_pin_", 1829042274, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 640, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("softExpand_pin_", 2113414506, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 728, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("foggyAmount_pin_", 2304662088, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 816, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("foggyExpand_pin_", 3506368940, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 904, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useColoring_pin_", 2711753462, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 992, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("soft_r_pin_", 4152931325, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1080, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("soft_g_pin_", 1554628540, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1168, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("soft_b_pin_", 813039533, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1256, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("foggy_r_pin_", 2350941491, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1344, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("foggy_g_pin_", 405601586, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1432, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("foggy_b_pin_", 3453525987, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1520, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sparkBlend_pin_", 3904850762, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1608, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sparkAttenuation_pin_", 2652219491, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1696, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sparkShape_pin_", 387722216, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1784, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sparkRotation_pin_", 1797147281, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1872, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useSparkColoring_pin_", 727619365, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1960, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("spark_r_pin_", 508836968, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2048, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("spark_g_pin_", 3265576721, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2136, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("spark_b_pin_", 4265126520, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2224, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}