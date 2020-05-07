using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu.Impl.MultiPlayer
{
    public partial class MultiPlayerCraftMenuEntity : Black.Entity.Menu.SwfEntryEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MultiPlayerCraftMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.Impl.MultiPlayer.MultiPlayerCraftMenuEntity", 0, Black.Entity.Menu.Impl.MultiPlayer.MultiPlayerCraftMenuEntity.ObjectType, null, properties, 0, 1152);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.Impl.MultiPlayer.MultiPlayerCraftMenuEntity", base.GetFieldProperties(), 1850513512, -192043492);
            return fieldProperties;
        }

		
    }
}