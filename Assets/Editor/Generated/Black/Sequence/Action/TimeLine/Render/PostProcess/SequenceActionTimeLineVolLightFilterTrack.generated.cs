using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render.PostProcess
{
    public partial class SequenceActionTimeLineVolLightFilterTrack : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.Sequence.ScreenEffect.VolLightFilterSequenceData masterData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineVolLightFilterTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineVolLightFilterTrack", 0, Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineVolLightFilterTrack.ObjectType, null, properties, 0, 576);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineVolLightFilterTrack", base.GetFieldProperties(), -914666305, 2115306997);
            
			fieldProperties.AddIndirectlyProperty(new Property("refInPorts_", 1035088696, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("refOutPorts_", 283683627, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triInPorts_", 291734708, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 96, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("triOutPorts_", 3107891487, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin*, MEMORY_CATEGORY_FRAMEWORK >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)4));
			fieldProperties.AddIndirectlyProperty(new Property("Isolated_", 56305607, "bool", 168, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_", 1657928633, "SQEX.Ebony.Framework.TimeControl.CurveList", 176, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("curveList_.propertyList_", 3952472237, "SQEX.Ebony.Std.DynamicArray< AnchorReferenceValue* >", 184, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddIndirectlyProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 208, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.pinName_", 3330161590, "Base.String", 216, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.name_", 192292993, "Base.String", 232, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.connections_", 490033121, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Node.GraphPin* >", 248, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayType_", 261766523, "SQEX.Ebony.Framework.Node.GraphPin.DelayType", 280, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayTime_", 1689218608, "float", 284, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("in_.delayMaxTime_", 1529341114, "float", 288, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.enabled_", 2295565220, "bool", 328, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.enableWeather_", 3172807716, "bool", 329, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.zNear_", 208140411, "float", 332, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.zFar_", 175213742, "float", 336, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.fogThickness_", 1184030261, "float", 340, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.mainlightPower_", 1133784239, "float", 344, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.locallightPower_", 697717845, "float", 348, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.ambientPower_", 2786962172, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.emissivePower_", 3070515983, "float", 356, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.tint_", 4174169752, "Luminous.RenderInterface.Color", 368, 16, 1, Property.PrimitiveType.Color, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.emissiveColor_", 2398789449, "Luminous.RenderInterface.Color", 384, 16, 1, Property.PrimitiveType.Color, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.ambientCubemapPower_", 3709317733, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.ambientCubemapTenPercentHeight_", 497965973, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.ambientCubemapStartY_", 4291399641, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.ambientDiffuseLightProbe_", 1678482931, "float", 412, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.noiseEnabled_", 3444030810, "bool", 416, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.noiseAmount_", 3351934649, "float", 420, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.noisePeriod_", 880423322, "float", 424, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.noiseScrollSpeed_", 25707081, "float", 428, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.noiseScrollRot_", 1618370023, "float", 432, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.noiseScrollTilt_", 317072607, "float", 436, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.heightFogEnabled_", 2637377401, "bool", 440, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.tenPercentHeight_", 2138319378, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.startY_", 591798358, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.playerRelative_", 2749542336, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.fadeInDistance_", 2968615157, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.fadeInToe_", 905281798, "float", 460, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.fadeInShoulder_", 2029911420, "float", 464, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.blurPassCountVSM_", 3551782454, "int", 468, 4, 1, Property.PrimitiveType.Int32, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.nearFarContrast_", 4042236080, "float", 472, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.extinction_", 4178475618, "float", 476, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.farFogEnabled_", 1275723475, "bool", 480, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.farFogThickness_", 3142953342, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.farFogZNear_", 2280034888, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.farFogZFar_", 2340888251, "float", 492, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.farFogHeightDecay_", 518935501, "float", 496, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.farFogDistanceDecay_", 337854317, "float", 500, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.farFogDepthDecay_", 2164618037, "float", 504, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.farFogExtinction_", 2088778327, "float", 508, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.farFogTint_", 146151465, "Luminous.RenderInterface.Color", 512, 16, 1, Property.PrimitiveType.Color, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.farFogStandardHeight_", 2969798980, "float", 528, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.farFogBottom_", 3974875951, "float", 532, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.farFogPlayerRelative_", 2621664501, "float", 536, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("masterData_.farFogRadius_", 782547332, "float", 540, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			
			
			fieldProperties.AddProperty(new Property("masterData_", 2084001356, "Black.Sequence.ScreenEffect.VolLightFilterSequenceData", 320, 224, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}