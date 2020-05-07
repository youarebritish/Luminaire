using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Enemy.ComponentData
{
    public partial class EnemyPartsAttackComponentData : Black.Actor.Component.ActorComponentData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new EnemyPartsAttackComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Enemy.ComponentData.EnemyPartsAttackComponentData", 0, Black.Actor.Component.Enemy.ComponentData.EnemyPartsAttackComponentData.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Enemy.ComponentData.EnemyPartsAttackComponentData", base.GetFieldProperties(), 1194559947, -457334712);
            
			
			
			return fieldProperties;
        }

		
    }
}