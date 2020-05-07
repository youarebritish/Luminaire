using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveEppFinalScore
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public sbyte ClearedMDay;
		public sbyte ClearedMonth;
		public short ClearedYear;
		public long PlayTime;
		public long ResultTime;
		public bool IsCleared;
		public Black.Save.Config.SaveEppStageScore StageScore;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEppFinalScore();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveEppFinalScore", 0, Black.Save.Config.SaveEppFinalScore.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveEppFinalScore", null, 1697672334, -1710360834);
            return fieldProperties;
        }

		
    }
}