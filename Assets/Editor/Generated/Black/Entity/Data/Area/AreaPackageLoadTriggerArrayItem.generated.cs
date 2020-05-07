using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Area
{
    public partial class AreaPackageLoadTriggerArrayItem : Black.Entity.Data.Area.PackageLoadAreaArrayItemBase
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

            var dummy = new AreaPackageLoadTriggerArrayItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Area.AreaPackageLoadTriggerArrayItem", 0, Black.Entity.Data.Area.AreaPackageLoadTriggerArrayItem.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Area.AreaPackageLoadTriggerArrayItem", base.GetFieldProperties(), 1514235959, -1100555636);
            
			
			
			return fieldProperties;
        }

		
    }
}