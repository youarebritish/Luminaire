using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.CharacterEntry
{
    public partial class CharacterEntryArrayItemBase : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CharacterEntryArrayItemBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.CharacterEntry.CharacterEntryArrayItemBase", 0, Black.Entity.Data.CharacterEntry.CharacterEntryArrayItemBase.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.CharacterEntry.CharacterEntryArrayItemBase", base.GetFieldProperties(), 581474944, -904059019);
            return fieldProperties;
        }

		
    }
}