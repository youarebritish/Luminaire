using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Body
{
    public partial class ActorEnvironmentDetectionComponent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorEnvironmentDetectionComponent();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Body.ActorEnvironmentDetectionComponent", 0, Black.Actor.Component.Body.ActorEnvironmentDetectionComponent.ObjectType, null, properties, 0, 136);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Body.ActorEnvironmentDetectionComponent", null, -153285116, -367153589);
            
			
			
			return fieldProperties;
        }

		
    }
}