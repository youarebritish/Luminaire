using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraTurn : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isOverrideLockOnLayer_;
		public bool isUseLockOnTurn_;
		public bool isUseLockOnTurnTilt_;
		public Black.Camera.Struct.CameraControlTurn controlTurn_;
		public Black.Camera.Struct.CameraAngleLimit angleLimit_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraTurn();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurn", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurn.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurn", base.GetFieldProperties(), -122247259, -1717097140);
            
			fieldProperties.AddIndirectlyProperty(new Property("controlTurn_.mode", 1185690371, "Black.Camera.Struct.CameraControlTurnMode", 24, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("controlTurn_.isUseAutoAdjustMode_", 3103072965, "bool", 28, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("controlTurn_.isUseAutoAdjustAngleMode_", 1954197702, "bool", 29, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("controlTurn_.isUseDefaultBrakeParam_", 2289140281, "bool", 30, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("controlTurn_.controlTurnVelocity_", 173668682, "float", 32, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("controlTurn_.backToDefaultTurnVelocity_", 1741478116, "float", 36, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("controlTurn_.yawMin_", 2883299558, "float", 40, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("controlTurn_.yawMax_", 2234915892, "float", 44, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("controlTurn_.tiltMin_", 760236634, "float", 48, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("controlTurn_.tiltMax_", 1407928752, "float", 52, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("controlTurn_.brakeAngleYaw_", 1792594110, "float", 56, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("controlTurn_.brakePowerYaw_", 3102752304, "float", 60, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("controlTurn_.brakeAngleTilt_", 3928828738, "float", 64, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("controlTurn_.brakePowerTilt_", 1493290388, "float", 68, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("angleLimit_.tiltAngleLimitMode_", 2706282977, "Black.Camera.CameraAngleLimitMode", 80, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("angleLimit_.tiltAngleLimitMin_", 915520886, "float", 84, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddIndirectlyProperty(new Property("angleLimit_.tiltAngleLimitMax_", 2409346404, "float", 88, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			
			
			fieldProperties.AddProperty(new Property("isOverrideLockOnLayer_", 3295476921, "bool", 8, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseLockOnTurn_", 1264502806, "bool", 9, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseLockOnTurnTilt_", 1966350115, "bool", 10, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("controlTurn_", 764311870, "Black.Camera.Struct.CameraControlTurn", 16, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("angleLimit_", 1897094620, "Black.Camera.Struct.CameraAngleLimit", 72, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}