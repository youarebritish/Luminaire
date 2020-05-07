using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Player
{
    public partial class SavePlayerStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint object_entry_id;
		public uint character_entry_id;
		public uint default_character_entry_id;
		public sbyte name;
		public uint name_id;
		public Black.Save.Player.SaveStatusStruct status;
		public Black.Save.Player.SavePlayerStatusStruct player_status;
		public int weapon_type;
		public Black.Save.Ability.SaveAbilityStruct ability;
		public Black.Save.Ability.SaveAbilityCountStruct ability_count;
		public Black.Save.Ability.SaveAbilityEffectCountStruct ability_effect_count;
		public Black.Save.Ability.SaveEnchantCountStruct weapon_ability;
		public Black.Save.Ability.SaveJobCommandStruct job_command;
		public Black.Save.Ability.SaveInspirationStruct inspiration;
		public Black.Save.Ability.SaveInspirationCheckStruct inspiration_check;
		public Black.Save.Ability.SaveInspirationElementCheckStruct inspiration_element_check;
		public Black.Save.Ability.SaveSkillStruct skill;
		public Black.Save.Player.SavePlayerPositionStruct position;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SavePlayerStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Player.SavePlayerStruct", 0, Black.Save.Player.SavePlayerStruct.ObjectType, null, properties, 0, 55232);
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

            fieldProperties = new PropertyContainer("Black.Save.Player.SavePlayerStruct", null, -937167067, 1560390726);
            
			
			
			return fieldProperties;
        }

		
    }
}