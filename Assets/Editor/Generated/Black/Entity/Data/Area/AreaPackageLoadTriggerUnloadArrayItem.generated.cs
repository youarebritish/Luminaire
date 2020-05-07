using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Area
{
    public partial class AreaPackageLoadTriggerUnloadArrayItem : Black.Entity.Data.Area.PackageLoadAreaArrayItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string filePath_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AreaPackageLoadTriggerUnloadArrayItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Area.AreaPackageLoadTriggerUnloadArrayItem", 0, Black.Entity.Data.Area.AreaPackageLoadTriggerUnloadArrayItem.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Area.AreaPackageLoadTriggerUnloadArrayItem", base.GetFieldProperties(), 1706470235, -1158998983);
            
			
			
			return fieldProperties;
        }

		
    }
}