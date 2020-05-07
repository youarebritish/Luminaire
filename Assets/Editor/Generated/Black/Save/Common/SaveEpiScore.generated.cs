using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Common
{
    public partial class SaveEpiScore
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int chapter;
		public int score;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEpiScore();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Common.SaveEpiScore", 0, Black.Save.Common.SaveEpiScore.ObjectType, null, properties, 0, 388);
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

            fieldProperties = new PropertyContainer("Black.Save.Common.SaveEpiScore", null, 862257242, -1995756868);
            
			
			
			return fieldProperties;
        }

		
    }
}