using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Party
{
    public partial class SavePartyStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.Save.Party.SavePartyMemberStruct member;
		public Black.Save.Party.SaveJobStruct job;
		public Black.Save.Ability.SaveAbilityCountStruct ability_count;
		public Black.Save.Ability.SaveAbilityEffectCountStruct ability_effect_count;
		public Black.Save.Ability.SaveAbilityInformationStruct ability_information;
		public Black.Save.Party.SavePartyDataStruct data;
		public Black.Save.Party.SaveSystemToggleStruct system_toggle;
		public Black.Save.Party.SaveTrophyStruct trophy;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SavePartyStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Party.SavePartyStruct", 0, Black.Save.Party.SavePartyStruct.ObjectType, null, properties, 0, 23880);
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

            fieldProperties = new PropertyContainer("Black.Save.Party.SavePartyStruct", null, -1047436391, -1064039247);
            
			fieldProperties.AddProperty(new Property("member", 719708611, "Black.Save.Party.SavePartyMemberStruct", 0, 20, 5, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("job", 3721670620, "Black.Save.Party.SaveJobStruct", 20, 552, 6, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("ability_count", 1904179969, "Black.Save.Ability.SaveAbilityCountStruct", 572, 4096, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ability_effect_count", 2728588471, "Black.Save.Ability.SaveAbilityEffectCountStruct", 4668, 1024, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ability_information", 3490697500, "Black.Save.Ability.SaveAbilityInformationStruct", 5692, 16384, 1024, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("data", 3631407781, "Black.Save.Party.SavePartyDataStruct", 22080, 880, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("system_toggle", 3945033081, "Black.Save.Party.SaveSystemToggleStruct", 22960, 128, 128, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("trophy", 1002300159, "Black.Save.Party.SaveTrophyStruct", 23088, 792, 99, Property.PrimitiveType.ClassField, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}