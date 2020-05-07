using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Menu
{
    public partial class SaveMenuFootprint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id_;
		public IList<uint> bitset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMenuFootprint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Menu.SaveMenuFootprint", 0, Black.Save.Menu.SaveMenuFootprint.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.Save.Menu.SaveMenuFootprint", null, 136861587, 2044925645);
            
			
			
			return fieldProperties;
        }

		
    }
}