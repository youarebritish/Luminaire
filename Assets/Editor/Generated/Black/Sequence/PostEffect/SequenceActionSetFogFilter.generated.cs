using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.PostEffect
{
    public partial class SequenceActionSetFogFilter : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pinEnable_;
		public bool enabled_;
		public UnityEngine.Color primaryColor_;
		public UnityEngine.Color secondaryColor_;
		public float heightFalloffStart_;
		public float heightFalloffDistance_;
		public float heightFalloffPower_;
		public float noizeVariance_;
		public float noizeAmplitude_;
		public float noizeFrequency_;
		public int noizeSampleCount_;
		public float noizeSampleStepFactor_;
		public float minDistance_;
		public bool infiniteNoise_;
		public float animSpeedX_;
		public float animSpeedY_;
		public float animSpeedZ_;
		public float lightInfluence_;
		public float skyboxAbsorption_;
		public bool zNewExpFog_;
		public float zDensity_;
		public float zSkyAngleStart_;
		public float zSkyAngleEnd_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin zSkyAngleEnd_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin zSkyAngleStart_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin zDensity_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin zNewExpFog_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin skyboxAbsorption_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin lightInfluence_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeedZ_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeedY_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeedX_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin infiniteNoise_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin minDistance_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin noizeSampleStepFactor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin noizeSampleCount_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin noizeFrequency_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin noizeAmplitude_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin noizeVariance_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin heightFalloffPower_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin heightFalloffDistance_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin heightFalloffStart_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin secondaryColor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin primaryColor_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetFogFilter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.PostEffect.SequenceActionSetFogFilter", 0, Black.Sequence.PostEffect.SequenceActionSetFogFilter.ObjectType, null, properties, 0, 2432);
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

            fieldProperties = new PropertyContainer("Black.Sequence.PostEffect.SequenceActionSetFogFilter", base.GetFieldProperties(), 1771367630, -1383292135);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinEnable_", 448653220, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 456, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("primaryColor_", 972090329, "Luminous.RenderInterface.Color", 464, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("secondaryColor_", 408865041, "Luminous.RenderInterface.Color", 480, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("heightFalloffStart_", 3996293045, "float", 496, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("heightFalloffDistance_", 1367703344, "float", 500, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("heightFalloffPower_", 138638678, "float", 504, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("noizeVariance_", 2349933696, "float", 508, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("noizeAmplitude_", 4167921954, "float", 512, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("noizeFrequency_", 3965376551, "float", 516, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("noizeSampleCount_", 3103343478, "int", 520, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("noizeSampleStepFactor_", 2873107576, "float", 524, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("minDistance_", 462922493, "float", 528, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("infiniteNoise_", 3888314930, "bool", 532, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeedX_", 4140296018, "float", 536, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeedY_", 4140148923, "float", 540, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeedZ_", 3066234212, "float", 544, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lightInfluence_", 1462574947, "float", 548, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("skyboxAbsorption_", 4203760267, "float", 552, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("zNewExpFog_", 1643182937, "bool", 556, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("zDensity_", 2165163156, "float", 560, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("zSkyAngleStart_", 3684233104, "float", 564, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("zSkyAngleEnd_", 65955007, "float", 568, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("zSkyAngleEnd_pin_", 3571263179, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 576, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("zSkyAngleStart_pin_", 27617664, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 664, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("zDensity_pin_", 1112185140, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 752, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("zNewExpFog_pin_", 1693965157, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 840, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("skyboxAbsorption_pin_", 1560173927, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 928, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lightInfluence_pin_", 4284105391, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1016, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeedZ_pin_", 1469886084, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1104, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeedY_pin_", 4151117015, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1192, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("animSpeedX_pin_", 1289109314, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1280, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("infiniteNoise_pin_", 3025110626, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("minDistance_pin_", 1264244057, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noizeSampleStepFactor_pin_", 2749306360, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1544, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noizeSampleCount_pin_", 515756614, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1632, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noizeFrequency_pin_", 4127367427, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1720, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noizeAmplitude_pin_", 3302544786, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1808, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("noizeVariance_pin_", 3573576624, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1896, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("heightFalloffPower_pin_", 2052196966, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1984, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("heightFalloffDistance_pin_", 2052229856, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2072, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("heightFalloffStart_pin_", 3720460289, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2160, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("secondaryColor_pin_", 4275566157, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2248, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("primaryColor_pin_", 254170085, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2336, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}