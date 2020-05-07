using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Monster
{
    public partial class ActorMonEmotionComponent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ActorMonEmotionComponent();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Monster.ActorMonEmotionComponent", 0, Black.Actor.Component.Monster.ActorMonEmotionComponent.ObjectType, null, properties, 0, 208);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Monster.ActorMonEmotionComponent", null, -810175155, -1297368379);
            
			
			
			return fieldProperties;
        }

		
    }
}