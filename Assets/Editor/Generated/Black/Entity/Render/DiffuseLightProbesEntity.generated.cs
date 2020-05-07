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
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scaling_", 3325430311, "SQEX.Luminous.Math.VectorA", 288, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("indoor_", 3843014775, "bool", 304, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("oceanOnly_", 1385946972, "bool", 305, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("blendLayer_", 64456310, "int", 308, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("probeMaskType_", 1846203086, "Black.Entity.Render.LightProbeEntityBase.PROBE_MASK_TYPE", 312, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fadeLengthXZ_", 3648846130, "SQEX.Luminous.Math.VectorA", 320, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("fadeLengthY_", 408022843, "SQEX.Luminous.Math.VectorA", 336, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("radius_", 2286360452, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("interpolationRadius_", 1399182860, "float", 356, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("enablePRT_", 2194915905, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableIrradiance_", 1180802057, "bool", 369, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("intensity_", 1363281103, "float", 372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("irradIntensity_", 838981167, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("irradColor_", 1646083173, "SQEX.Luminous.RenderInterface.Color", 384, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("useDirLightShadow_", 1513720650, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotateSHWithGrid_", 2418083090, "bool", 404, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("intensityForSLPBake_", 1798527272, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableFogMasking_", 2802426511, "bool", 412, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("pointCountX_", 2788193469, "unsigned int", 416, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("pointCountZ_", 1714720043, "unsigned int", 420, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("useTransformForBounding_", 1429702100, "bool", 424, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeOutStart_", 2053168800, "float", 428, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("fadeOutEnd_", 1356959567, "float", 432, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("gridScale_", 1110648014, "LM_NS_MATH.VectorA", 448, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("gridOffset_", 1151253315, "LM_NS_MATH.VectorA", 464, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("noYfade_", 1703295328, "bool", 480, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("attachToNavMeshCB_", 1796052411, "bool", 481, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("floorOffset_", 918590807, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("resetOffsetsBtn_", 2007525285, "bool", 488, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("saveProbeStates_", 935752937, "bool", 489, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("renderInfluence_", 1055556861, "bool", 490, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("renderDebugSpheres_", 1795570903, "bool", 491, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("renderBoundingVolume_", 760908256, "bool", 492, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("debugSphereSize_", 1937935009, "float", 496, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("debugSpheresRawSH_", 195138152, "bool", 500, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourceDirectory_", 2687263660, "Ebony.Base.String", 504, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourceFileName_", 1506120470, "Ebony.Base.String", 520, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("pathToPRT_", 617456776, "Ebony.Base.String", 536, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("pathToPRTD_", 109409490, "Ebony.Base.String", 552, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("pathToIRR_", 1116496719, "Ebony.Base.String", 568, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("reload_", 2928751401, "bool", 584, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bake_", 2992693773, "bool", 585, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("presetType_", 933785587, "Black.Entity.Render.DiffuseLightProbesEntity.PRESET_TYPE", 588, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("createPreset_", 845970251, "bool", 592, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("preview_", 271593880, "bool", 593, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("previewProbeNumber_", 2139685207, "int", 596, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("bakeIrradiance_", 1687808419, "bool", 600, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bakeIrradianceWithEmissive_", 2383635990, "bool", 601, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("numBounces_", 3576821381, "int", 604, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("outputDebugIVCubeMaps_", 1496130899, "bool", 608, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("prtSmoothAmount_", 1572786888, "float", 612, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("irradSmoothAmount_", 4005551628, "float", 616, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("smooth_", 992000976, "bool", 620, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}