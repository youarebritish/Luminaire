using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class KeyHelpHudEntity : Black.Entity.Menu.SwfEntryEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new KeyHelpHudEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.KeyHelpHudEntity", 0, Black.Entity.Menu.KeyHelpHudEntity.ObjectType, null, properties, 0, 512);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.KeyHelpHudEntity", base.GetFieldProperties(), 15580397, 1418840325);
            return fieldProperties;
        }

		
    }
}