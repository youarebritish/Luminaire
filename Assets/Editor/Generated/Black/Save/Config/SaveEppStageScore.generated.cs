using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveEppStageScore
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public long ResultTime;
		public int CoinCount;
		public int CoinBonus;
		public int KillCount;
		public int KillBonus;
		public int TotalBonus;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEppStageScore();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveEppStageScore", 0, Black.Save.Config.SaveEppStageScore.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveEppStageScore", null, 1517503952, 2111343169);
            
			
			
			return fieldProperties;
        }

		
    }
}