using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.MultiPlayer.WorldShareCreate
{
    public partial class ActorCreateCommander
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorCreateCommander();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.MultiPlayer.WorldShareCreate.ActorCreateCommander", 0, Black.MultiPlayer.WorldShareCreate.ActorCreateCommander.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.MultiPlayer.WorldShareCreate.ActorCreateCommander", null, -824808292, 1466748182);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}