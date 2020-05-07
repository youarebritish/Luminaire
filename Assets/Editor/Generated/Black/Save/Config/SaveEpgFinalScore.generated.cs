using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveEpgFinalScore
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public sbyte ClearedMDay;
		public sbyte ClearedMonth;
		public short ClearedYear;
		public long PlayTime;
		public Black.Save.Config.SaveEpgStageScore StageScore1;
		public Black.Save.Config.SaveEpgStageScore StageScore2;
		public Black.Save.Config.SaveEpgStageScore StageScore3;
		public Black.Save.Config.SaveEpgStageScore StageScore4;
		public bool IsCleared;
		public int ItemScore;
		public int TotalScore;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEpgFinalScore();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveEpgFinalScore", 0, Black.Save.Config.SaveEpgFinalScore.ObjectType, null, properties, 0, 144);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveEpgFinalScore", null, 1697653825, 1318909800);
            
			
			
			return fieldProperties;
        }

		
    }
}