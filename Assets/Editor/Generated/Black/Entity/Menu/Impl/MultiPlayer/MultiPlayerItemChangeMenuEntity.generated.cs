using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu.Impl.MultiPlayer
{
    public partial class MultiPlayerItemChangeMenuEntity : Black.Entity.Menu.SwfEntryEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MultiPlayerItemChangeMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.Impl.MultiPlayer.MultiPlayerItemChangeMenuEntity", 0, Black.Entity.Menu.Impl.MultiPlayer.MultiPlayerItemChangeMenuEntity.ObjectType, null, properties, 0, 640);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.Impl.MultiPlayer.MultiPlayerItemChangeMenuEntity", base.GetFieldProperties(), 286032881, 2019607186);
            return fieldProperties;
        }

		
    }
}