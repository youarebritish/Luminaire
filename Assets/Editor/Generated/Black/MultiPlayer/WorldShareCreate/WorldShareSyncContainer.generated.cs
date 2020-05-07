using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.MultiPlayer.WorldShareCreate
{
    public partial class WorldShareSyncContainer
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new WorldShareSyncContainer();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.MultiPlayer.WorldShareCreate.WorldShareSyncContainer", 0, Black.MultiPlayer.WorldShareCreate.WorldShareSyncContainer.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.MultiPlayer.WorldShareCreate.WorldShareSyncContainer", null, -1723140811, 457010697);
            return fieldProperties;
        }

		
    }
}