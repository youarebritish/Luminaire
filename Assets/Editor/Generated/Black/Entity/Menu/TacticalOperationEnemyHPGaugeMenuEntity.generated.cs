using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class TacticalOperationEnemyHPGaugeMenuEntity : Black.Entity.Menu.EnemyHPGaugeMenuEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TacticalOperationEnemyHPGaugeMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.TacticalOperationEnemyHPGaugeMenuEntity", 0, Black.Entity.Menu.TacticalOperationEnemyHPGaugeMenuEntity.ObjectType, null, properties, 0, 704);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.TacticalOperationEnemyHPGaugeMenuEntity", base.GetFieldProperties(), 1294818519, -1190581736);
            return fieldProperties;
        }

		
    }
}