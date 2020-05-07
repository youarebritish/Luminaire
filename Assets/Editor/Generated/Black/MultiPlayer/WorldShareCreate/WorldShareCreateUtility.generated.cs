using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.MultiPlayer.WorldShareCreate
{
    public partial class WorldShareCreateUtility
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new WorldShareCreateUtility();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.MultiPlayer.WorldShareCreate.WorldShareCreateUtility", 0, Black.MultiPlayer.WorldShareCreate.WorldShareCreateUtility.ObjectType, null, properties, 0, 1);
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

            fieldProperties = new PropertyContainer("Black.MultiPlayer.WorldShareCreate.WorldShareCreateUtility", null, 1481993155, 879729640);
            
			
			
			return fieldProperties;
        }

		
    }
}