using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class PackageLoadAreaSimpleEntity : Black.Entity.Node.PackageLoadEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool triggerEnable_;
		public float triggerRadius_;
		public float triggerHeight_;
		public float triggerWidth_;
		public float triggerDepth_;
		public UnityEngine.Vector4 triggerOffset_;
		public string lodLowPackageName_;
		public bool isLowPackageLoad_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PackageLoadAreaSimpleEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.PackageLoadAreaSimpleEntity", 0, Black.Entity.Node.PackageLoadAreaSimpleEntity.ObjectType, null, properties, 0, 544);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.PackageLoadAreaSimpleEntity", base.GetFieldProperties(), 540167991, 774288417);
            
			
			
			return fieldProperties;
        }

		
    }
}