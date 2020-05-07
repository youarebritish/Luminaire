using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class MultiPlayerDialogPictureMenuEntity : Black.Entity.Menu.SwfEntryEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MultiPlayerDialogPictureMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.MultiPlayerDialogPictureMenuEntity", 0, Black.Entity.Menu.MultiPlayerDialogPictureMenuEntity.ObjectType, null, properties, 0, 816);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.MultiPlayerDialogPictureMenuEntity", base.GetFieldProperties(), 773448696, 1461194028);
            return fieldProperties;
        }

		
    }
}