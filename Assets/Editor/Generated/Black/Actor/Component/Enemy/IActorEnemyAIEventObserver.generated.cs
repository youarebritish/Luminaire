using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Enemy
{
    public partial class IActorEnemyAIEventObserver
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new IActorEnemyAIEventObserver();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Enemy.IActorEnemyAIEventObserver", 0, Black.Actor.Component.Enemy.IActorEnemyAIEventObserver.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Enemy.IActorEnemyAIEventObserver", null, -63101790, 1099158262);
            return fieldProperties;
        }

		
    }
}