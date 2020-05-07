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
            
			fieldProperties.AddProperty(new Property("animModel_", 1506932998, "Ebony.Base.String", 416, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("animPack_", 3062714746, "Ebony.Base.String", 432, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("animGraph_", 1402134577, "Ebony.Base.String", 448, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("animClip_", 2780642699, "Ebony.Base.String", 464, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("bnmData_", 1116532569, "Ebony.Base.String", 480, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("clsnData_", 797135496, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 496, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("naviMeshUpdateType_", 2947277674, "Black.Entity.SkeletalModelEntity.NaviMeshUpdateType", 512, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("umbraIsGate_", 3965297522, "bool", 516, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("kineDriverData_", 1787284419, "Ebony.Base.String", 520, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairData_", 2086647970, "Ebony.Base.String", 536, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairWorksData_", 1452757742, "Ebony.Base.String", 552, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairWorksDataList_", 2689103450, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 568, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("hairWorksMaterial_", 3542579597, "Ebony.Base.String", 584, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("hairWorksModelDirectPath_", 4277343993, "Ebony.Base.String", 600, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionParamId_", 3572570526, "SQEX.Ebony.Std.Fixid", 616, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionItemId_", 4287093562, "SQEX.Ebony.Std.Fixid", 620, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionMaskOff_", 3728935017, "bool", 624, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionAttachBoneId_", 2647789846, "SQEX.Ebony.Std.Fixid", 628, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionAttachBoneOffset_", 2412011140, "Luminous.Math.VectorA", 640, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("componentType_", 2579083861, "Black.Actor.ActorComponentMap.ADDITIONAL_COMPONENT", 656, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("actorSlowEnabled_", 2911151581, "bool", 660, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}