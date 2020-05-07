using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class TacticalOperationTargetCursorMenuEntity : Black.Entity.Menu.TargetCursorMenuEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TacticalOperationTargetCursorMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.TacticalOperationTargetCursorMenuEntity", 0, Black.Entity.Menu.TacticalOperationTargetCursorMenuEntity.ObjectType, null, properties, 0, 576);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.TacticalOperationTargetCursorMenuEntity", base.GetFieldProperties(), -624107843, -1000726319);
            return fieldProperties;
        }

		
    }
}