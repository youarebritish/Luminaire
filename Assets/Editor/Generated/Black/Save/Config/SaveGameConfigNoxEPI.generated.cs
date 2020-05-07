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
            
			
			
			fieldProperties.AddProperty(new Property("cleared", 3899202675, "bool", 0, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("played", 1117382050, "bool", 1, 4, 4, Property.PrimitiveType.Bool, 0, (char)8));
			fieldProperties.AddProperty(new Property("HiScore", 3456560864, "int32_t", 8, 32, 8, Property.PrimitiveType.Int32, 0, (char)8));
			fieldProperties.AddProperty(new Property("EpiScoreBoard", 492330805, "Black.Save.Config.SaveEpiScoreRanking", 40, 1640, 5, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("cleared_if", 4241279395, "bool", 1680, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}