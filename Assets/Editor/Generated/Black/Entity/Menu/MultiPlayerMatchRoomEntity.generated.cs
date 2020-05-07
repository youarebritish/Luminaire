using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class MultiPlayerMatchRoomEntity : Black.Entity.Menu.SwfEntryEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MultiPlayerMatchRoomEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.MultiPlayerMatchRoomEntity", 0, Black.Entity.Menu.MultiPlayerMatchRoomEntity.ObjectType, null, properties, 0, 704);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.MultiPlayerMatchRoomEntity", base.GetFieldProperties(), 2050730230, -283880272);
            return fieldProperties;
        }

		
    }
}