using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class MultiPlayerInformationWindowMenuEntity : Black.Entity.Menu.SwfEntryEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MultiPlayerInformationWindowMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.MultiPlayerInformationWindowMenuEntity", 0, Black.Entity.Menu.MultiPlayerInformationWindowMenuEntity.ObjectType, null, properties, 0, 752);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.MultiPlayerInformationWindowMenuEntity", base.GetFieldProperties(), -2129570303, -2073890742);
            return fieldProperties;
        }

		
    }
}