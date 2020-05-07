using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Ambient
{
    public partial class AmbientSmartLocationBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int minCoolDown_;
		public int maxCoolDown_;
		public bool triggerCooldownOnStartup_;
		public int characterCapacity_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> interactionGroups_;
		public bool useDefaultActivator_;
		public float defaultActivatorRadius_;
		public int defaultActivationPeriod_;
		public int npcMinCoolDown_;
		public int npcMaxCoolDown_;
		public int scriptPriority_;
		public bool useExternalActivator_;
		public float externalActivatorRadius_;
		public int externalActivationPeriod_;
		public bool usePlayerActivator_;
		public int playerActivationPeriod_;
		public bool useSingleActionActivator_;
		public float singleActionActivatorRadius_;
		public int singleActionActivationPeriod_;
		public uint singleActionId_;
		public uint singleActionParamId_;
		public int singleActionParam_;
		public float singleActionProbability_;
		public int singleActionMinCoolDown_;
		public int singleActionMaxCoolDown_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> tags_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AmbientSmartLocationBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Ambient.AmbientSmartLocationBase", 0, Black.AI.Ambient.AmbientSmartLocationBase.ObjectType, null, properties, 0, 128);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.AI.Ambient.AmbientSmartLocationBase", null, -2066062127, -1947466606);
            return fieldProperties;
        }

		
    }
}