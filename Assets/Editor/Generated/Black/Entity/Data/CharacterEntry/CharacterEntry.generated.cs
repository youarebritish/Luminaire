using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.CharacterEntry
{
    public partial class CharacterEntry : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint EntryId;
		public string DisplayName;
		public bool IsVisible;
		public int ActorType_;
		public bool UseCharaParamId;
		public uint CharaParamId;
		public uint OverwriteParameterID_;
		public bool UseCharaParamId1;
		public uint CharaParamId1;
		public uint AIParamId;
		public uint LinkAnimId;
		public string ModelDirectPath;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> modelChangePathList;
		public int defaultModelChangeWear;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> modelChangeWearPathList;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> modelChangeKineDriverDataList;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> modelChangeKineDriverAfterBonamikDataList;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> modelChangeBnmDataList;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> ElementIdPathList;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> PsdDataList;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> HairDataList;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> HairWorksDataList;
		public string HairWorksMaterial;
		public string HairWorksModelDirectPath;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> KineDriverDataList;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> KineDriverAfterBonamikDataList;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryMaterialParamArrayItem> MaterialParamList;
		public float lodScale_;
		public bool UseStyleEdit;
		public string LmAnimMdlData;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> LmAnimPackDataList;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> LmAnimGraphDataList;
		public string AnimConstraintData;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> BnmDataList;
		public uint BnmPartsTableId;
		public int BgCollisionType;
		public uint DestructionId;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> ArticulationDataList;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> DynamicsDataList;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> BodyDriverDataList;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> ClsnDataList;
		public bool OverlapInstanceIgnoreBaseScaling;
		public float StepOffset;
		public string vehicleChassisClsnData_;
		public uint InteractionParamId;
		public uint InteractionItemId;
		public bool ScopeOutFlag;
		public bool ScopeOutVisible;
		public float ScopeOutRange;
		public int ScopeOutRangeCheckInterval;
		public int ScopeOutUpdateCount;
		public string MapClsn;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> VlinkPathList;
		public int DefaultAIControllerType;
		public string AIGraphData;
		public string BodyGraphData;
		public string Command0;
		public string Command1;
		public string Command2;
		public string Command2Sub;
		public string CommandUpdate;
		public string TypeCommonAI0;
		public string Schedule0;
		public string Schedule1;
		public string InitializeOnlyAI0;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> PartsIdList;
		public uint SoundFootStep;
		public string RustleLongSoundFile_;
		public string RustleShortSoundFile_;
		public string RustleStandSoundFile_;
		public string RustleSitSoundFile_;
		public string RustleFootSoundFile_;
		public string WingFlapUpFile_;
		public string WingFlapDownFile_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> SwingKnockFileNames_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> SwingRubFileNames_;
		public string RagdollImpactFile_;
		public string ProcedualSoundConfig_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> ExtraSoundFileNames;
		public int autoSeType_;
		public uint seParam_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> AddTagList;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> VehicleIdList;
		public string ModelSwapPartsName;
		public uint NotifyAlterna;
		public uint NotifyDeath;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CharacterEntry();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.CharacterEntry.CharacterEntry", 0, Black.Entity.Data.CharacterEntry.CharacterEntry.ObjectType, null, properties, 0, 1128);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.CharacterEntry.CharacterEntry", base.GetFieldProperties(), 1243728343, 1220872069);
            
			
			
			return fieldProperties;
        }

		
    }
}