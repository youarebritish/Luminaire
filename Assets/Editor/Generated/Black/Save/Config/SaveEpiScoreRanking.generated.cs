using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveEpiScoreRanking
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public long bestScore;
		public Black.Save.Config.SaveEpiFinalScore EpiScoreRanking;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEpiScoreRanking();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveEpiScoreRanking", 0, Black.Save.Config.SaveEpiScoreRanking.ObjectType, null, properties, 0, 328);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveEpiScoreRanking", null, -1578888346, 239009982);
            return fieldProperties;
        }

		
    }
}