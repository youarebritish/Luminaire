using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Camera.Struct
{
    public partial class CameraAngleLimit : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int tiltAngleLimitMode_;
		public float tiltAngleLimitMin_;
		public float tiltAngleLimitMax_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CameraAngleLimit();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Camera.Struct.CameraAngleLimit", 0, Black.Camera.Struct.CameraAngleLimit.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.Camera.Struct.CameraAngleLimit", base.GetFieldProperties(), -731158199, 589371655);
            return fieldProperties;
        }

		
    }
}