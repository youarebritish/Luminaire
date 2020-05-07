using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraGeneralStart : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isUse_;
		public bool isCutChangeOrder_;
		public bool isNeedClearCameraContainerBlendDataWhenCutChange_;
		public float interpTime_;
		public int interpBlendMode_;
		public bool isUseCommonData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart pogData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart povData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYawStart turnYawData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTiltStart turnTiltData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollStart turnRollData_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovStartNew fovData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraGeneralStart();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralStart", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralStart.ObjectType, null, properties, 0, 184);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralStart", base.GetFieldProperties(), 1239833791, -742281100);
            
			fieldProperties.AddProperty(new Property("isUse_", 318966273, "bool", 8, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCutChangeOrder_", 320944258, "bool", 9, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNeedClearCameraContainerBlendDataWhenCutChange_", 2284833010, "bool", 10, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("interpTime_", 2206145623, "float", 12, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("interpBlendMode_", 3870805242, "SQEX.Ebony.Framework.TimeControl.InterpMode", 16, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseCommonData_", 315510974, "bool", 20, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("pogData_", 3340733518, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart", 24, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("povData_", 1033385879, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPogStart", 40, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnYawData_", 1189308438, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYawStart", 56, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnTiltData_", 79670634, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTiltStart", 88, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnRollData_", 1042086494, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollStart", 120, 32, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fovData_", 3792695137, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovStartNew", 152, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}