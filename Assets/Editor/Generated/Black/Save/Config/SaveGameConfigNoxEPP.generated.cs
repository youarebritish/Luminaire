using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveGameConfigNoxEPP
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool cleared;
		public bool played;
		public Black.Save.Config.SaveEppScoreRanking EppScoreBoard;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveGameConfigNoxEPP();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveGameConfigNoxEPP", 0, Black.Save.Config.SaveGameConfigNoxEPP.ObjectType, null, properties, 0, 1952);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveGameConfigNoxEPP", null, -1420705936, -1593875547);
            
			
			
			return fieldProperties;
        }

		
    }
}