using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Render
{
    public partial class SequenceActionSetProceduralCloud : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enableWeather_;
		public float cloudWindDirection_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cloudWindDirectionPin_;
		public float cloudWindSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cloudWindSpeedPin_;
		public float altitudeElevation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin altitudeElevationPin_;
		public float altitudeThickness_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin altitudeThicknessPin_;
		public UnityEngine.Color sunlightForCloud_;
		public float sunlightIntensityForCloud_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunlightIntensityForCloudPin_;
		public UnityEngine.Color ambientTopColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientTopColorPin_;
		public float ambientTopIntensity_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientTopIntensityForCloudPin_;
		public UnityEngine.Color ambientBottomColor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientBottomColorPin_;
		public float ambientBottomIntensity_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientBottomIntensityForCloudPin_;
		public float extinctionScatteringFactorX100_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin extinctionScatteringFactorX100Pin_;
		public float drawDistance_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin drawDistancePin_;
		public float atmScatterScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin atmScatterScalePin_;
		public float atmScatterPower_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin atmScatterPowerPin_;
		public float atmScatterScale_sunDiskCover_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin atmScatterScaleSunDiskCoverPin_;
		public float atmScatterPower_sunDiskCover_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin atmScatterPowerSunDiskCoverPin_;
		public bool useNewSystem_;
		public float amplitude1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin amplitude1Pin_;
		public float amplitude2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin amplitude2Pin_;
		public float amplitude3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin amplitude3Pin_;
		public float amplitude4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin amplitude4Pin_;
		public float amplitude5_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin amplitude5Pin_;
		public float amplitude6_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin amplitude6Pin_;
		public float amplitude7_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin amplitude7Pin_;
		public float frequency1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequency1Pin_;
		public float frequency2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequency2Pin_;
		public float frequency3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequency3Pin_;
		public float frequency4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequency4Pin_;
		public float frequency5_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequency5Pin_;
		public float frequency6_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequency6Pin_;
		public float frequency7_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequency7Pin_;
		public float frequencyMultAll_;
		public float frequencyY1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequencyY1Pin_;
		public float frequencyY2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequencyY2Pin_;
		public float frequencyY3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequencyY3Pin_;
		public float frequencyY4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin frequencyY4Pin_;
		public float animSpeed1_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeed1Pin_;
		public float animSpeed2_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeed2Pin_;
		public float animSpeed3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeed3Pin_;
		public float animSpeed4_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeed4Pin_;
		public float animSpeed5_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeed5Pin_;
		public float animSpeed6_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeed6Pin_;
		public float animSpeed7_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin animSpeed7Pin_;
		public float heightDensityFalloff_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin heightDensityFalloffPin_;
		public float densityAmbientFactor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin densityAmbientFactorPin_;
		public float lightingAnisotropy_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin lightingAnisotropyPin_;
		public float lightingContrast_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin lightingContrastPin_;
		public float coverage_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin coveragePin_;
		public float highCloudOpacity_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin highCloudOpacityPin_;
		public UnityEngine.Color sunlightHighCloud_;
		public float sunlightIntensityForHighCloud_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sunlightIntensityForHighCloudPin_;
		public float lightingAnisotropyHighCloud_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin lightingAnisotropyHighCloudPin_;
		public float groundShadowScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin groundShadowScalePin_;
		public float shadowOpacity_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin shadowOpacityPin_;
		public float shadowContrast_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin shadowContrastPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetProceduralCloud();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Render.SequenceActionSetProceduralCloud", 0, Black.Sequence.Action.Render.SequenceActionSetProceduralCloud.ObjectType, null, properties, 0, 5328);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Render.SequenceActionSetProceduralCloud", base.GetFieldProperties(), -1683402606, 416072340);
            
			
			
			return fieldProperties;
        }

		
    }
}