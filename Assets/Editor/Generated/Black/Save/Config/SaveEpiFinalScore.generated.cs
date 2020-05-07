using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Config
{
    public partial class SaveEpiFinalScore
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public sbyte ClearedMDay;
		public sbyte ClearedMonth;
		public short ClearedYear;
		public long PlayTime;
		public int Rank;
		public bool IsCleared;
		public int Score;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveEpiFinalScore();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Config.SaveEpiFinalScore", 0, Black.Save.Config.SaveEpiFinalScore.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.Save.Config.SaveEpiFinalScore", null, 1697671251, 266482192);
            return fieldProperties;
        }

		
    }
}