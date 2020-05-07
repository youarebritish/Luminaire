using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class PackageUnloadEntity : Black.Entity.Node.PackageLoadEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Entity.Data.Area.PackageLoadAreaUnloadArrayItem> unloadItemList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PackageUnloadEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.PackageUnloadEntity", 0, Black.Entity.Node.PackageUnloadEntity.ObjectType, null, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.PackageUnloadEntity", base.GetFieldProperties(), -1966069553, 1506896903);
            
			
			
			return fieldProperties;
        }

		
    }
}