using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Physics
{
    public partial class FurDataEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int furType_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> furCurvePaths_;
		public string maskTexturePath_;
		public string furMaterialPath_;
		public string baseMeshName_;
		public int furResolution_;
		public int masterStrandPerTriangle_;
		public int slaveStrandPerMaster_;
		public bool enableDraw_;
		public float furStiffness_;
		public float furDamping_;
		public bool enableCollision_;
		public float furSegmentLength_;
		public float furMeshWidth_;
		public float tipShrinkage_;
		public UnityEngine.Vector4 tipOffset_;
		public float furSlaveDistScale_;
		public float furFollicleLengthScale_;
		public bool flattenNormal_;
		public float textureSizeX_;
		public float textureSizeY_;
		public float alphaMapRepeat_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new FurDataEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Physics.FurDataEntity", 0, Black.Entity.Data.Physics.FurDataEntity.ObjectType, null, properties, 0, 272);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Physics.FurDataEntity", base.GetFieldProperties(), -421536977, -70824769);
            
			
			
			fieldProperties.AddProperty(new Property("furType_", 3203267351, "Black.Entity.Data.Physics.FurDataEntity.eFURTYPE", 64, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("furCurvePaths_", 387965792, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 72, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("maskTexturePath_", 585615376, "Ebony.Base.String", 88, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("furMaterialPath_", 2904688877, "Ebony.Base.String", 104, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("baseMeshName_", 596167939, "Ebony.Base.String", 120, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("furResolution_", 3295946597, "int", 136, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("masterStrandPerTriangle_", 27661399, "int", 140, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("slaveStrandPerMaster_", 2005601374, "int", 144, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableDraw_", 427792549, "bool", 148, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("furStiffness_", 122597212, "float", 152, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("furDamping_", 399247073, "float", 156, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableCollision_", 3854874595, "bool", 160, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("furSegmentLength_", 1753719372, "float", 164, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("furMeshWidth_", 1932232886, "float", 168, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tipShrinkage_", 1996256767, "float", 172, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("tipOffset_", 929010758, "Luminous.Math.VectorA", 176, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("furSlaveDistScale_", 1360302530, "float", 192, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("furFollicleLengthScale_", 647920461, "float", 196, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("flattenNormal_", 1776010955, "bool", 200, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("textureSizeX_", 3470700080, "float", 204, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("textureSizeY_", 249353305, "float", 208, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("alphaMapRepeat_", 1125835657, "float", 212, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}