using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class MapPhotoMenuEntity : Black.Entity.Menu.MapMenuEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MapPhotoMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.MapPhotoMenuEntity", 0, Black.Entity.Menu.MapPhotoMenuEntity.ObjectType, null, properties, 0, 1776);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.MapPhotoMenuEntity", base.GetFieldProperties(), -1002391951, -1248077268);
            
			
			
			return fieldProperties;
        }

		
    }
}