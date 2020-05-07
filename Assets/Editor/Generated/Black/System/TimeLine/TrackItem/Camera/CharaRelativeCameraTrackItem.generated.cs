using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class CharaRelativeCameraTrackItem : Black.System.TimeLine.TrackItem.CameraCCFTrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isAddPog_;
		public bool isAddPov_;
		public bool isAddUp_;
		public uint baseElementId_;
		public bool isCalcTilt_;
		public bool isCalcRoll_;
		public bool bIsAttach_;
		public UnityEngine.Vector4 relativeOffset_;
		public UnityEngine.Vector4 relativeRotation_;
		public bool isCheckCollision_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.CharaRelativeCameraCollision collisionOpt_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CharaRelativeCameraTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.CharaRelativeCameraTrackItem", 0, Black.System.TimeLine.TrackItem.Camera.CharaRelativeCameraTrackItem.ObjectType, null, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.CharaRelativeCameraTrackItem", base.GetFieldProperties(), 209008462, -1315130045);
            
			fieldProperties.AddProperty(new Property("isAddPog_", 3699576207, "bool", 344, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isAddPov_", 3702386326, "bool", 345, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isAddUp_", 3544180066, "bool", 346, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("baseElementId_", 630624006, "SQEX.Ebony.Std.Fixid", 348, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCalcTilt_", 3159764420, "bool", 352, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCalcRoll_", 4201800344, "bool", 353, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bIsAttach_", 3675418929, "bool", 354, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("relativeOffset_", 2366110807, "SQEX.Luminous.Math.VectorA", 368, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("relativeRotation_", 1396190808, "SQEX.Luminous.Math.VectorA", 384, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCheckCollision_", 1357258370, "bool", 400, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("collisionOpt_", 2405266377, "Black.System.TimeLine.TrackItem.Camera.Struct.CharaRelativeCameraCollision", 408, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}