//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;

namespace Black.Entity
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class HairModelEntity : Black.Entity.StaticModelEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string animModel_= string.Empty;
		public string animPack_= string.Empty;
		public string animGraph_= string.Empty;
		public string animClip_= string.Empty;
		public string bnmData_= string.Empty;
		[UnityEngine.SerializeReference] public List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> clsnData_= new List<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem>();
		public string kineDriverData_= string.Empty;
		public uint interactionParamId_;
		public uint interactionItemId_;
		public bool interactionMaskOff_;
		public uint interactionAttachBoneId_;
		public UnityEngine.Vector4 interactionAttachBoneOffset_;
		public int componentType_;
		public string sourcePathHairMaterial_= string.Empty;
		public string hairVTCFilename_= string.Empty;
		public bool reloadGmtl_;
		public float hairAmount_;
		public int hairDrawMode_;
		public int hairShadingMode_;
		public float hairWidth_;
		public float hairShadowWidth_;
		public float hairBlendNormal_;
		public float thinTipOffset_;
		public int hairStrandMultiplier_;
		public float multiplicationRootOffset_;
		public float multiplicationMiddleOffset_;
		public float multiplicationTipOffset_;
		public bool hairTessellation_;
		public int hairVertsPerSegment_;
		[UnityEngine.SerializeReference] public List<Black.Entity.HairGroupParameter> hairGroupParams_= new List<Black.Entity.HairGroupParameter>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new HairModelEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.HairModelEntity", 0, Black.Entity.HairModelEntity.ObjectType, Construct, properties, 0, 720);
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

            fieldProperties = new PropertyContainer("Black.Entity.HairModelEntity", base.GetFieldProperties(), 1852397041, 1825241041);
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sourcePath_", 341055184, "Ebony.Base.String", 256, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sourceHighSpecPath_", 2930328893, "Ebony.Base.String", 272, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scaling_", 3325430311, "float", 288, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("visible_", 3296750298, "bool", 292, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scriptVisibleOff_", 1178151850, "bool", 293, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lodLevelHold_", 1405210608, "bool", 294, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lodScaling_", 4277247494, "float", 296, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("linkAnimId_", 1980597938, "SQEX.Ebony.Std.Fixid", 300, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("casterShadow_", 1875170918, "bool", 304, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("receiveShadow_", 4251594463, "bool", 305, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("ignoreIndoorLightProbes_", 339085568, "bool", 306, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("depthOnly_", 2344384041, "bool", 307, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useMeshCollision_", 468627668, "bool", 308, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("setMeshCollisionOff_", 1547327668, "bool", 309, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("MeshCollision_", 2780030513, "Ebony.Base.String", 312, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useMeshCollisionMovingTile_", 1615091370, "bool", 328, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("useMeshCollisionAirMovingTile_", 4074814524, "bool", 329, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("naviMeshBuildType_", 455690061, "Black.Entity.StaticModelEntity.NaviMeshBuildType", 332, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("materialParamColor_", 3459353649, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Material.MaterialParameterColor* >", 336, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("materialParamValue1_", 636517702, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Material.MaterialParameterValue1* >", 352, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("materialParamValue4_", 3856878739, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Material.MaterialParameterValue4* >", 368, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isTerrainBakeEnabled_", 506619421, "bool", 384, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isFoliageCheckThrough_", 1457859362, "bool", 385, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("turfBaseObject_", 1134715033, "bool", 386, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("umbraIsBakeTarget_", 4216184219, "bool", 387, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("umbraIsBakeTargetEvenIncludesTranslucent_", 1181221071, "bool", 388, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("animModel_", 1506932998, "Ebony.Base.String", 416, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("animPack_", 3062714746, "Ebony.Base.String", 432, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("animGraph_", 1402134577, "Ebony.Base.String", 448, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("animClip_", 2780642699, "Ebony.Base.String", 464, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmData_", 1116532569, "Ebony.Base.String", 480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("clsnData_", 797135496, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 496, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("kineDriverData_", 1787284419, "Ebony.Base.String", 512, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionParamId_", 3572570526, "SQEX.Ebony.Std.Fixid", 528, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionItemId_", 4287093562, "SQEX.Ebony.Std.Fixid", 532, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionMaskOff_", 3728935017, "bool", 536, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionAttachBoneId_", 2647789846, "SQEX.Ebony.Std.Fixid", 540, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionAttachBoneOffset_", 2412011140, "Luminous.Math.VectorA", 544, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("componentType_", 2579083861, "Black.Actor.ActorComponentMap.ADDITIONAL_COMPONENT", 560, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("sourcePathHairMaterial_", 4115300323, "Ebony.Base.String", 568, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairVTCFilename_", 3324934646, "Ebony.Base.String", 584, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("reloadGmtl_", 220868993, "bool", 600, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairAmount_", 2021470206, "float", 604, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairDrawMode_", 1557364429, "Black.Entity.HairModelEntity.HAIR_DRAW_MODE", 608, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairShadingMode_", 2845755939, "Black.Entity.HairModelEntity.HAIR_SHADING_MODE", 612, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairWidth_", 3868230244, "float", 616, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairShadowWidth_", 1991172168, "float", 620, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairBlendNormal_", 1767470984, "float", 624, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("thinTipOffset_", 2870584157, "float", 628, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairStrandMultiplier_", 382366395, "int", 632, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("multiplicationRootOffset_", 3631532657, "float", 636, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("multiplicationMiddleOffset_", 2962896850, "float", 640, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("multiplicationTipOffset_", 4032638440, "float", 644, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairTessellation_", 772923669, "bool", 648, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairVertsPerSegment_", 3851474272, "int", 652, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairGroupParams_", 2676721547, "SQEX.Ebony.Std.DynamicArray< Black.Entity.HairGroupParameter* >", 656, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new HairModelEntity();
        }
		
    }
}