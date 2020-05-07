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
            
			fieldProperties.AddProperty(new Property("object_entry_id", 868490063, "SQEX.Ebony.Std.Fixid", 4, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("character_entry_id", 216598113, "SQEX.Ebony.Std.Fixid", 8, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("default_character_entry_id", 3039116423, "SQEX.Ebony.Std.Fixid", 12, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("name", 2369371622, "char", 16, 128, 128, Property.PrimitiveType.Int8, 0, (char)8));
			fieldProperties.AddProperty(new Property("name_id", 3355607158, "SQEX.Ebony.Std.Fixid", 144, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("status", 3125508079, "Black.Save.Player.SaveStatusStruct", 152, 1536, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("player_status", 96348663, "Black.Save.Player.SavePlayerStatusStruct", 1688, 140, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("weapon_type", 1761553146, "Black.Actor.WEAPON_TYPE", 1828, 16, 4, Property.PrimitiveType.Enum, 0, (char)8));
			fieldProperties.AddProperty(new Property("ability", 3471506833, "Black.Save.Ability.SaveAbilityStruct", 1844, 32228, 1151, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("ability_count", 1904179969, "Black.Save.Ability.SaveAbilityCountStruct", 34072, 8192, 2, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("ability_effect_count", 2728588471, "Black.Save.Ability.SaveAbilityEffectCountStruct", 42264, 2048, 2, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("weapon_ability", 2604204528, "Black.Save.Ability.SaveEnchantCountStruct", 44312, 80, 2, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("job_command", 2134253846, "Black.Save.Ability.SaveJobCommandStruct", 44392, 256, 16, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("inspiration", 3359413299, "Black.Save.Ability.SaveInspirationStruct", 44648, 2048, 256, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("inspiration_check", 2044175116, "Black.Save.Ability.SaveInspirationCheckStruct", 46696, 8192, 2048, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("inspiration_element_check", 863795739, "Black.Save.Ability.SaveInspirationElementCheckStruct", 54888, 256, 64, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("skill", 3390427190, "Black.Save.Ability.SaveSkillStruct", 55144, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("position", 2471448074, "Black.Save.Player.SavePlayerPositionStruct", 55168, 64, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}