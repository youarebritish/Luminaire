using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Player
{
    public partial class SavePlayerStatusStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int exp;
		public int exp_total;
		public int ability_point;
		public int step_count;
		public int step_count_battle_result;
		public int step_count_camp;
		public int step_count_gladiolus;
		public int phantom_sword_amount;
		public int kill_count;
		public int damage_count;
		public int damage_ratio;
		public int damage_ratio_max;
		public int reserve1;
		public int reserve2;
		public int reserve3;
		public int reserve4;
		public int reserve5;
		public int reserve6;
		public int reserve7;
		public int reserve8;
		public SQEX.Ebony.Base.RTC.DateTime invincible_suits_date;
		public int invincible_suits_count;
		public int invincible_suits_time;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SavePlayerStatusStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Player.SavePlayerStatusStruct", 0, Black.Save.Player.SavePlayerStatusStruct.ObjectType, null, properties, 0, 140);
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

            fieldProperties = new PropertyContainer("Black.Save.Player.SavePlayerStatusStruct", null, -748940090, 114902487);
            return fieldProperties;
        }

		
    }
}