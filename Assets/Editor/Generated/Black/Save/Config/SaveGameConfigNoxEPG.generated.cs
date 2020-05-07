using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveGameConfigNoxEPG
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int highScore;
		public bool cleared;
		public bool played;
		public Black.Save.Config.SaveEpgFinalScore EpgScoreRanking;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveGameConfigNoxEPG();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveGameConfigNoxEPG", 0, Black.Save.Config.SaveGameConfigNoxEPG.ObjectType, null, properties, 0, 1456);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveGameConfigNoxEPG", null, -1421557904, 1611742678);
            return fieldProperties;
        }

		
    }
}