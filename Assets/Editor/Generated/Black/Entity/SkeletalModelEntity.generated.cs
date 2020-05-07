using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity
{
    public partial class SkeletalModelEntity : Black.Entity.StaticModelEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string animModel_;
		public string animPack_;
		public string animGraph_;
		public string animClip_;
		public string bnmData_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> clsnData_;
		public int naviMeshUpdateType_;
		public bool umbraIsGate_;
		public string kineDriverData_;
		public string hairData_;
		public string hairWorksData_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> hairWorksDataList_;
		public string hairWorksMaterial_;
		public string hairWorksModelDirectPath_;
		public uint interactionParamId_;
		public uint interactionItemId_;
		public bool interactionMaskOff_;
		public uint interactionAttachBoneId_;
		public UnityEngine.Vector4 interactionAttachBoneOffset_;
		public int componentType_;
		public bool actorSlowEnabled_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SkeletalModelEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.SkeletalModelEntity", 0, Black.Entity.SkeletalModelEntity.ObjectType, null, properties, 0, 768);
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

            fieldProperties = new PropertyContainer("Black.Entity.SkeletalModelEntity", base.GetFieldProperties(), -2047471063, -1432273448);
            
			
			
			return fieldProperties;
        }

		
    }
}