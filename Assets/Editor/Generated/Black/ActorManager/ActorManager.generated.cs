using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.ActorManager
{
    public partial class ActorManager
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorManager();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.ActorManager.ActorManager", 0, Black.ActorManager.ActorManager.ObjectType, null, properties, 26, 51968);
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

            fieldProperties = new PropertyContainer("Black.ActorManager.ActorManager", null, -2057450186, 1959963856);
            return fieldProperties;
        }

		
    }
}