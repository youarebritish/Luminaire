using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveGameConfigNoxEPI
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool cleared;
		public bool played;
		public int HiScore;
		public Black.Save.Config.SaveEpiScoreRanking EpiScoreBoard;
		public bool cleared_if;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveGameConfigNoxEPI();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveGameConfigNoxEPI", 0, Black.Save.Config.SaveGameConfigNoxEPI.ObjectType, null, properties, 0, 1688);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveGameConfigNoxEPI", null, -1422213264, 1745866340);
            
			
			
			return fieldProperties;
        }

		
    }
}