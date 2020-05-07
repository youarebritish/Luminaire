using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveEpgStageScore
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int TotalScore;
		public int Point1;
		public int Point2;
		public int Point3;
		public int Point4;
		public int Point5;
		public int Point6;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEpgStageScore();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveEpgStageScore", 0, Black.Save.Config.SaveEpgStageScore.ObjectType, null, properties, 0, 28);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveEpgStageScore", null, 1517485435, -1027956599);
            
			
			
			return fieldProperties;
        }

		
    }
}