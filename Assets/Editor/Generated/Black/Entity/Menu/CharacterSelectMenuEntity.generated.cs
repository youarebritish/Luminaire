using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class CharacterSelectMenuEntity : Black.Entity.Menu.StateMenuBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CharacterSelectMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.CharacterSelectMenuEntity", 0, Black.Entity.Menu.CharacterSelectMenuEntity.ObjectType, null, properties, 0, 832);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.CharacterSelectMenuEntity", base.GetFieldProperties(), -325333457, -410919710);
            return fieldProperties;
        }

		
    }
}