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
            
			
			
			fieldProperties.AddProperty(new Property("minCoolDown_", 4002648055, "int", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxCoolDown_", 1686966705, "int", 4, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerCooldownOnStartup_", 2352980045, "bool", 8, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("characterCapacity_", 2138905361, "int", 12, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("interactionGroups_", 125379156, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem* >", 16, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("useDefaultActivator_", 572401405, "bool", 32, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("defaultActivatorRadius_", 3687545052, "float", 36, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("defaultActivationPeriod_", 3916605936, "int", 40, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("npcMinCoolDown_", 1681135214, "int", 44, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("npcMaxCoolDown_", 2873526840, "int", 48, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("scriptPriority_", 699961715, "Black.AI.Ambient.AmbientSmartLocationBase.ExecutionPriority", 52, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("useExternalActivator_", 4201786171, "bool", 56, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("externalActivatorRadius_", 2743668528, "float", 60, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("externalActivationPeriod_", 2681151756, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("usePlayerActivator_", 2305886973, "bool", 68, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("playerActivationPeriod_", 1722461818, "int", 72, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("useSingleActionActivator_", 3840016234, "bool", 76, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("singleActionActivatorRadius_", 580968345, "float", 80, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("singleActionActivationPeriod_", 210236943, "int", 84, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("singleActionId_", 215196187, "SQEX.Ebony.Std.Fixid", 88, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("singleActionParamId_", 3834026558, "SQEX.Ebony.Std.Fixid", 92, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("singleActionParam_", 3353006133, "int", 96, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("singleActionProbability_", 1181090443, "float", 100, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("singleActionMinCoolDown_", 4279688285, "int", 104, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("singleActionMaxCoolDown_", 2593857067, "int", 108, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("tags_", 1058374253, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem* >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			
			
			return fieldProperties;
        }

		
    }
}