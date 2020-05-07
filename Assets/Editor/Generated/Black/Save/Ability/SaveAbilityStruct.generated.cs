using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Ability
{
    public partial class SaveAbilityStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public int ability_id;
		public int level;
		public int weapon_bank_number;
		public bool exist;
		public bool enchant;
		public bool noctis_only;
		public bool weapon_only;
		public bool party;
		public int count;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveAbilityStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Ability.SaveAbilityStruct", 0, Black.Save.Ability.SaveAbilityStruct.ObjectType, null, properties, 0, 28);
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

            fieldProperties = new PropertyContainer("Black.Save.Ability.SaveAbilityStruct", null, -681977700, 78742591);
            return fieldProperties;
        }

		
    }
}