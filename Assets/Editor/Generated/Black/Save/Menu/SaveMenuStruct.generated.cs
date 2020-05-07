using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Menu
{
    public partial class SaveMenuStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int version_;
		public uint activeQuestId_;
		public uint activeQuestDestId_;
		public IList<uint> discoveredLocations_;
		public IList<Black.Save.Menu.SaveMenuFootprint> footPrints_;
		public int userDestType_;
		public uint userDestId_;
		public double[] userDestLocation_;
		public int visibleFlag_;
		public IList<uint> battleItemOrderList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMenuStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Menu.SaveMenuStruct", 0, Black.Save.Menu.SaveMenuStruct.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("Black.Save.Menu.SaveMenuStruct", null, -578333456, -1940980057);
            return fieldProperties;
        }

		
    }
}