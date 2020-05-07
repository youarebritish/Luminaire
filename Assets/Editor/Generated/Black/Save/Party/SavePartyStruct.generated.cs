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
            
			
			
			return fieldProperties;
        }

		
    }
}