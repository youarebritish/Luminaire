using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class MultiPlayerCampResultEntity : Black.Entity.Menu.SwfEntryEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MultiPlayerCampResultEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.MultiPlayerCampResultEntity", 0, Black.Entity.Menu.MultiPlayerCampResultEntity.ObjectType, null, properties, 0, 544);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.MultiPlayerCampResultEntity", base.GetFieldProperties(), -809214708, 899150344);
            return fieldProperties;
        }

		
    }
}