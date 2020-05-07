using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Render
{
    public partial class DiffuseLightProbesEntity : Black.Entity.Render.LightProbeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enablePRT_;
		public bool enableIrradiance_;
		public float intensity_;
		public float irradIntensity_;
		public UnityEngine.Color irradColor_;
		public float useDirLightShadow_;
		public bool rotateSHWithGrid_;
		public float intensityForSLPBake_;
		public bool enableFogMasking_;
		public int pointCountX_;
		public int pointCountZ_;
		public bool useTransformForBounding_;
		public float fadeOutStart_;
		public float fadeOutEnd_;
		public UnityEngine.Vector4 gridScale_;
		public UnityEngine.Vector4 gridOffset_;
		public bool noYfade_;
		public bool attachToNavMeshCB_;
		public float floorOffset_;
		public bool resetOffsetsBtn_;
		public bool saveProbeStates_;
		public bool renderInfluence_;
		public bool renderDebugSpheres_;
		public bool renderBoundingVolume_;
		public float debugSphereSize_;
		public bool debugSpheresRawSH_;
		public string sourceDirectory_;
		public string sourceFileName_;
		public string pathToPRT_;
		public string pathToPRTD_;
		public string pathToIRR_;
		public bool reload_;
		public bool bake_;
		public int presetType_;
		public bool createPreset_;
		public bool preview_;
		public int previewProbeNumber_;
		public bool bakeIrradiance_;
		public bool bakeIrradianceWithEmissive_;
		public int numBounces_;
		public bool outputDebugIVCubeMaps_;
		public float prtSmoothAmount_;
		public float irradSmoothAmount_;
		public bool smooth_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new DiffuseLightProbesEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Render.DiffuseLightProbesEntity", 0, Black.Entity.Render.DiffuseLightProbesEntity.ObjectType, null, properties, 0, 816);
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

            fieldProperties = new PropertyContainer("Black.Entity.Render.DiffuseLightProbesEntity", base.GetFieldProperties(), 528912217, -1016881177);
            return fieldProperties;
        }

		
    }
}