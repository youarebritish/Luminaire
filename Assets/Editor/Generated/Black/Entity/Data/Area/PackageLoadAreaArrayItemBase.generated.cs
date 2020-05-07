using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Area
{
    public partial class PackageLoadAreaArrayItemBase : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int Id_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PackageLoadAreaArrayItemBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Area.PackageLoadAreaArrayItemBase", 0, Black.Entity.Data.Area.PackageLoadAreaArrayItemBase.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Area.PackageLoadAreaArrayItemBase", base.GetFieldProperties(), -232094109, -1545906488);
            
			
			
			return fieldProperties;
        }

		
    }
}