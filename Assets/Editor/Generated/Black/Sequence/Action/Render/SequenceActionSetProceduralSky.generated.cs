using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Render
{
    public partial class SequenceActionSetProceduralSky : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enableWeather_;
		public bool enableEVControl_;
		public float sunBrightness_;
		public float sunBrightnessEV_;
		public float moonBrightness_;
		public float moonBrightnessEV_;
		public float airThickness_;
		public float turbidityR_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turbidityRPin_;
		public float rayleighOvercastRate_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rayleighOvercastRatePin_;
		public float turbidityM_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turbidityMPin_;
		public float sunAsymmetry_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunAsymetryPin_;
		public float mieColorR_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mieColorRPin_;
		public float mieColorG_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mieColorGPin_;
		public float mieColorB_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mieColorBPin_;
		public UnityEngine.Color sunDiskColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunDiskColorPin_;
		public float sunDiskRadiation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunDiskRadiationPin_;
		public float sunDiskRelativeSize_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunDiskRelativeSizePin_;
		public UnityEngine.Color moonDiskColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moonDiskColorPin_;
		public float moonDiskRadiation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moonDiskRadiationPin_;
		public float moonDiskRelativeSize_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moonDiskRelativeSizePin_;
		public UnityEngine.Color sunColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunColorPin_;
		public float sunBrightnessSky_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunBrightnessSkyPin_;
		public UnityEngine.Color moonColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moonColorPin_;
		public float moonBrightnessSky_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin moonBrightnessSkyPin_;
		public UnityEngine.Color mainLightSunColor_;
		public float sunLightScale_;
		public UnityEngine.Color mainLightMoonColor_;
		public float moonLightScale_;
		public UnityEngine.Color envSunColor_;
		public float envSunScale_;
		public UnityEngine.Color envMoonColor_;
		public float envMoonScale_;
		public float starSize_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin starSizePin_;
		public float starExtinctionHorizon_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin starExtinctionHorizoPin_;
		public float starBrightness_;
		public float starBrightnessEV_;
		public float tilingStarBrightness_;
		public float tilingStarBrightnessEV_;
		public float milkywayBrightness_;
		public float milkywayBrightnessEV_;
		public float starTwinkleSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin starTwinkleSpeedPin_;
		public float tilingStarTwinkleSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin tilingStarTwinkleSpeedPin_;
		public UnityEngine.Color backgroundColor_;
		public float backgroundColorIntensity_;
		public float backgroundColorIntensityEV_;
		public UnityEngine.Color groundColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groundColorPin_;
		public float groundAlbedo_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groundAlbedoPin_;
		public float groundColorSpread_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groundColorSpreadPin_;
		public float groundSpreadUp_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groundSpreadUpPin_;
		public float horizonOffset_;
		public float extinctionStart_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin extinctionStartPin_;
		public float extinctionEnd_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin extinctionEndPin_;
		public float extinctionFalloff_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin extinctionFalloffPin_;
		public UnityEngine.Color midgroundColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin midgroundColorPin_;
		public float midgroundIntensity_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin midgroundIntensityPin_;
		public float viewElevationAngle_;
		public float viewElevationAttenuation_;
		public float axisTilt_;
		public float axisAzimuth_;
		public float centerOfRotationHeightOffset_;
		public float meridianTime_;
		public float moonAxisTilt_;
		public float moonAxisAzimuth_;
		public float moonCenterOfRotationHeightOffset_;
		public float moonMeridianTime_;
		public float starAxisTilt_;
		public float starAxisAzimuth_;
		public float starMeridianTime_;
		public float sunDuration_;
		public float moonDuration_;
		public float START_DAY_;
		public float END_DAY_;
		public float moonriseOffset_;
		public float ambientIntensity_;
		public float directionalIntensity_;
		public float ambientSpecUseDirLightShadow_;
		public float shadowPower_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetProceduralSky();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Render.SequenceActionSetProceduralSky", 0, Black.Sequence.Action.Render.SequenceActionSetProceduralSky.ObjectType, null, properties, 0, 3632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Render.SequenceActionSetProceduralSky", base.GetFieldProperties(), 374908728, 1957126268);
            
			
			
			return fieldProperties;
        }

		
    }
}