using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class StatusPanelNoctMenuEntity : Black.Entity.Menu.StatusPanelMenuEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new StatusPanelNoctMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.StatusPanelNoctMenuEntity", 0, Black.Entity.Menu.StatusPanelNoctMenuEntity.ObjectType, null, properties, 0, 624);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.StatusPanelNoctMenuEntity", base.GetFieldProperties(), 2092616220, 684520437);
            return fieldProperties;
        }

		
    }
}