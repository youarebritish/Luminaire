using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Party
{
    public partial class SavePartyDataStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int usercontrol_player_save_number;
		public int chapter;
		public int gil;
		public int medal;
		public int coin;
		public int ability_point;
		public int reward_count;
		public int clear_count;
		public bool newgame_plus;
		public bool premium_camera_status;
		public bool premium_camera_equipment;
		public float element_power;
		public float phantom_gauge;
		public float phantom_gauge_max;
		public bool job_command_available;
		public float job_command_gauge;
		public float job_command_gauge_max;
		public int strategy_probability;
		public uint camp_point_fixid;
		public string camp_point_area_file_path;
		public bool isLoopDungeon;
		public int loopDungeonLevel;
		public uint before_camp_point_fixid;
		public int link_count;
		public int death_count;
		public int kill_count;
		public int picture_count;
		public long world_time;
		public long total_seconds;
		public string weather_key;
		public int weather_type;
		public int weather_index_command;
		public int move_distance_type;
		public Black.Save.Party.SaveMoveDistanceStruct move;
		public int battle_result_rank;
		public int battle_result_count;
		public double[] camp_point_;
		public double[] before_camp_point_;
		public double[] loopDungeonBasePoint_;
		public double[] loopDungeonCampPoint_;
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

            var dummy = new SavePartyDataStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Party.SavePartyDataStruct", 0, Black.Save.Party.SavePartyDataStruct.ObjectType, null, properties, 0, 880);
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

            fieldProperties = new PropertyContainer("Black.Save.Party.SavePartyDataStruct", null, 1403872290, 2094854431);
            return fieldProperties;
        }

		
    }
}