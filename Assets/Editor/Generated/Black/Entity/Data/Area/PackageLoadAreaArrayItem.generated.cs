using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Area
{
    public partial class PackageLoadAreaArrayItem : Black.Entity.Data.Area.PackageLoadAreaArrayItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string filePath_;
		public bool autoUnload_;
		public float unloadMargin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PackageLoadAreaArrayItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Area.PackageLoadAreaArrayItem", 0, Black.Entity.Data.Area.PackageLoadAreaArrayItem.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Area.PackageLoadAreaArrayItem", base.GetFieldProperties(), -1904969059, 2071382286);
            return fieldProperties;
        }

		
    }
}