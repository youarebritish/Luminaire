using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class StatusPanelPromptoMenuEntity : Black.Entity.Menu.StatusPanelMenuEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new StatusPanelPromptoMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.StatusPanelPromptoMenuEntity", 0, Black.Entity.Menu.StatusPanelPromptoMenuEntity.ObjectType, null, properties, 0, 576);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.StatusPanelPromptoMenuEntity", base.GetFieldProperties(), -679045290, -329823883);
            return fieldProperties;
        }

		
    }
}