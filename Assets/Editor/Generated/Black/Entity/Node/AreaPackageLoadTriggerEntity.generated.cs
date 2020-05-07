using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class AreaPackageLoadTriggerEntity : Black.Entity.Node.PackageLoadEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Entity.Data.Area.AreaPackageLoadTriggerArrayItem> loadItemList_;
		public IList<Black.Entity.Data.Area.AreaPackageLoadTriggerUnloadArrayItem> unloadItemList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AreaPackageLoadTriggerEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.AreaPackageLoadTriggerEntity", 0, Black.Entity.Node.AreaPackageLoadTriggerEntity.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.AreaPackageLoadTriggerEntity", base.GetFieldProperties(), 909082020, -998769290);
            return fieldProperties;
        }

		
    }
}