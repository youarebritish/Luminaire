using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class FishingRodSelectMenuEntity : Black.Entity.Menu.ImageSelectMenuEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new FishingRodSelectMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.FishingRodSelectMenuEntity", 0, Black.Entity.Menu.FishingRodSelectMenuEntity.ObjectType, null, properties, 0, 608);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.FishingRodSelectMenuEntity", base.GetFieldProperties(), 2146739531, 1355416433);
            return fieldProperties;
        }

		
    }
}