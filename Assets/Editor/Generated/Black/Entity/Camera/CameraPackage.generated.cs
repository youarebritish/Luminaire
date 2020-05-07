using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Camera
{
    public partial class CameraPackage : Black.Entity.Actor.ActorPackageBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CameraPackage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Camera.CameraPackage", 0, Black.Entity.Camera.CameraPackage.ObjectType, null, properties, 0, 624);
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

            fieldProperties = new PropertyContainer("Black.Entity.Camera.CameraPackage", base.GetFieldProperties(), 1059313535, 1284708448);
            return fieldProperties;
        }

		
    }
}