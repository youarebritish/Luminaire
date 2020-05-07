using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity
{
    public partial class HairModelEntity : Black.Entity.StaticModelEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string animModel_;
		public string animPack_;
		public string animGraph_;
		public string animClip_;
		public string bnmData_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> clsnData_;
		public string kineDriverData_;
		public uint interactionParamId_;
		public uint interactionItemId_;
		public bool interactionMaskOff_;
		public uint interactionAttachBoneId_;
		public UnityEngine.Vector4 interactionAttachBoneOffset_;
		public int componentType_;
		public string sourcePathHairMaterial_;
		public string hairVTCFilename_;
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
		public IList<Black.Entity.HairGroupParameter> hairGroupParams_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new HairModelEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.HairModelEntity", 0, Black.Entity.HairModelEntity.ObjectType, null, properties, 0, 720);
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
            
			
			
			return fieldProperties;
        }

		
    }
}