using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Player
{
    public partial class SaveStatusStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public int party_index;
		public bool join;
		public bool joined;
		public int sortie;
		public bool disable_sortie;
		public bool menu_invisible;
		public bool immortal;
		public bool pinch_available;
		public bool damage_limit_over;
		public bool parameter_limit_over;
		public int pinch_time;
		public int pinch_no_hit_time;
		public int pinch_recover_no_hit_time;
		public bool recover_non_battle_only;
		public int hp;
		public int hp_max;
		public int maximum_hp_max;
		public int minimum_hp_max;
		public int maximum_hp_max_buffer;
		public int ratio_minimum_hp_max;
		public int ratio_auto_recover_hp;
		public int ratio_pinch_damage_hp_max;
		public int ratio_poison_damage_hp;
		public int ratio_poison_damage_hp_max;
		public int ratio_pinch_poison_hp_max;
		public int ratio_deadly_poison_damage_hp;
		public int ratio_burning_damage_hp;
		public int ratio_frigid_damage_hp;
		public int ratio_ring_damage_hp;
		public int ratio_auto_recover_mp;
		public int ratio_armed_form_use_mp;
		public int ratio_death_use_mp;
		public int ratio_holy_use_mp;
		public float death_sentence;
		public int hp_bonus;
		public int mp;
		public int mp_max;
		public float ep;
		public float ep_max;
		public float stamina;
		public float stamina_max;
		public int level;
		public int level_cap;
		public int level_max;
		public int strength;
		public int vitality;
		public int magic;
		public int spirit;
		public int critical;
		public int element_attack;
		public int element_absorption;
		public int element_invalidity;
		public short element_tolerance;
		public int status_auto;
		public int status;
		public sbyte status_attack;
		public sbyte status_defence;
		public long status_count_auto;
		public sbyte status_count;
		public sbyte status_count_attack;
		public sbyte status_count_attack_time;
		public sbyte status_count_defence;
		public short status_count_time;
		public float status_count_delta_time;
		public sbyte status_count_record;
		public int buff_registration_count;
		public Black.Save.Player.SaveBuffStruct buff;
		public int buff_count;
		public float buff_time;
		public float start_buff_time;
		public float mp_burst_time;
		public float mp_burst_time_max;
		public float element_damage_time;
		public int weapon_use_number;
		public int weapon_slot_amount;
		public int knights_of_eos;
		public bool age;
		public bool injured;
		public bool child;
		public bool miners;
		public bool first_person;
		public bool friend_control;
		public bool jacket_off;
		public bool tears;
		public bool ring;
		public bool ability_available;
		public float dirty;
		public Black.Save.Ability.SaveAbilityEquipmentStruct ability;
		public Black.Save.Ability.SaveAbilityEquipmentMenuStruct ability_menu;
		public Black.Save.Equipment.SaveWeaponEquipmentStruct weapon;
		public Black.Save.Ability.SaveJobCommandEquipmentStruct job_command;
		public Black.Save.Equipment.SaveWeaponEquipmentStruct accessory;
		public Black.Save.Equipment.SaveClothEquipmentStruct cloth;
		public int reserve1;
		public int reserve2;
		public int reserve3;
		public int reserve4;
		public int reserve5;
		public int reserve6;
		public int reserve7;
		public int reserve8;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveStatusStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Player.SaveStatusStruct", 0, Black.Save.Player.SaveStatusStruct.ObjectType, null, properties, 0, 1536);
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

            fieldProperties = new PropertyContainer("Black.Save.Player.SaveStatusStruct", null, -1930500420, -1712780495);
            
			
			
			return fieldProperties;
        }

		
    }
}