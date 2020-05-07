using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.PostEffect
{
    public partial class SequenceActionSetSAO : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enabled_;
		public float intensity_;
		public float contrast_;
		public float bias_;
		public float falloffRadius_;
		public float spiralTurns_;
		public float blurThreshold_;
		public float blurThresholdNormal_;
		public float blurFalloff_;
		public float blurDistFalloff_;
		public int numSamples_;
		public float temporalNearThreshold_;
		public float temporalFarExpFactor_;
		public float skinAOStrength_;
		public float eyeAOStrength_;
		public float backscatterAOStrength_;
		public bool directionalLightAO_;
		public float directionalLightAOStrength_;
		public float directionalLightAOMultiplier_;
		public float directionalLightAOContrast_;
		public float directionalLightAOFalloffStart_;
		public float directionalLightAOFalloffEnd_;
		public bool enableNewFoliageAO_;
		public float foliageAOStrength_;
		public float foliageAOMultiplier_;
		public float foliageAOContrast_;
		public float foliageAOFalloffStart_;
		public float foliageAOFalloffEnd_;
		public bool enableNewFoliageAODebug_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin numSamples_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blurDistFalloff_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blurFalloff_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blurThresholdNormal_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blurThreshold_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spiralTurns_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin falloffRadius_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin bias_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin contrast_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin intensity_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin temporalNearThreshold_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin temporalFarExpFactor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enabled_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetSAO();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.PostEffect.SequenceActionSetSAO", 0, Black.Sequence.PostEffect.SequenceActionSetSAO.ObjectType, null, properties, 0, 1632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.PostEffect.SequenceActionSetSAO", base.GetFieldProperties(), -211387948, 1163944939);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("intensity_", 1363281103, "float", 372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("contrast_", 469235780, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("bias_", 3623439873, "float", 380, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("falloffRadius_", 243467364, "float", 384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("spiralTurns_", 1060541737, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurThreshold_", 3068405932, "float", 392, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurThresholdNormal_", 376950945, "float", 396, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurFalloff_", 718202779, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurDistFalloff_", 2408477115, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("numSamples_", 1102027747, "int", 408, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("temporalNearThreshold_", 20160245, "float", 412, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("temporalFarExpFactor_", 2130938373, "float", 416, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("skinAOStrength_", 2640787310, "float", 420, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("eyeAOStrength_", 1234180892, "float", 424, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("backscatterAOStrength_", 1333490246, "float", 428, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalLightAO_", 3409266470, "bool", 432, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalLightAOStrength_", 3967092341, "float", 436, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalLightAOMultiplier_", 2778608611, "float", 440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalLightAOContrast_", 2120704412, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalLightAOFalloffStart_", 922636360, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalLightAOFalloffEnd_", 1114259655, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableNewFoliageAO_", 4254368052, "bool", 456, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("foliageAOStrength_", 204025982, "float", 460, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("foliageAOMultiplier_", 1141895492, "float", 464, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("foliageAOContrast_", 1890203395, "float", 468, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("foliageAOFalloffStart_", 904815151, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("foliageAOFalloffEnd_", 126567008, "float", 476, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableNewFoliageAODebug_", 1182582063, "bool", 480, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("numSamples_pin_", 346556207, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 488, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurDistFalloff_pin_", 305749463, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 576, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurFalloff_pin_", 3752540151, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 664, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurThresholdNormal_pin_", 3886339165, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 752, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blurThreshold_pin_", 3225240700, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 840, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("spiralTurns_pin_", 1462403253, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 928, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("falloffRadius_pin_", 1058905476, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1016, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bias_pin_", 171959421, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1104, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("contrast_pin_", 424064932, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1192, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("intensity_pin_", 1676690907, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1280, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("temporalNearThreshold_pin_", 2556478273, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("temporalFarExpFactor_pin_", 1150073553, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_pin_", 3058841247, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1544, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}