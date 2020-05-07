using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class StyleEditMenuEntity : Black.Entity.Menu.StateMenuBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new StyleEditMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.StyleEditMenuEntity", 0, Black.Entity.Menu.StyleEditMenuEntity.ObjectType, null, properties, 0, 5296);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.StyleEditMenuEntity", base.GetFieldProperties(), -1477154970, -1770431237);
            
			
			
			return fieldProperties;
        }

		
    }
}