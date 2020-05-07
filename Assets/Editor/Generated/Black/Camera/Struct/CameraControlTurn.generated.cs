using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Camera.Struct
{
    public partial class CameraControlTurn : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int mode;
		public bool isUseAutoAdjustMode_;
		public bool isUseAutoAdjustAngleMode_;
		public bool isUseDefaultBrakeParam_;
		public float controlTurnVelocity_;
		public float backToDefaultTurnVelocity_;
		public float yawMin_;
		public float yawMax_;
		public float tiltMin_;
		public float tiltMax_;
		public float brakeAngleYaw_;
		public float brakePowerYaw_;
		public float brakeAngleTilt_;
		public float brakePowerTilt_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CameraControlTurn();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Camera.Struct.CameraControlTurn", 0, Black.Camera.Struct.CameraControlTurn.ObjectType, null, properties, 0, 56);
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

            fieldProperties = new PropertyContainer("Black.Camera.Struct.CameraControlTurn", base.GetFieldProperties(), -1676972646, 589691802);
            return fieldProperties;
        }

		
    }
}