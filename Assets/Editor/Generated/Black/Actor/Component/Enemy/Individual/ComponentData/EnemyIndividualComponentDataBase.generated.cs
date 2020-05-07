using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Enemy.Individual.ComponentData
{
    public partial class EnemyIndividualComponentDataBase : Black.Actor.Component.ActorComponentData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new EnemyIndividualComponentDataBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Enemy.Individual.ComponentData.EnemyIndividualComponentDataBase", 0, Black.Actor.Component.Enemy.Individual.ComponentData.EnemyIndividualComponentDataBase.ObjectType, null, properties, 0, 64);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Actor.Component.Enemy.Individual.ComponentData.EnemyIndividualComponentDataBase", base.GetFieldProperties(), 1634267038, 2134066031);
            return fieldProperties;
        }

		
    }
}