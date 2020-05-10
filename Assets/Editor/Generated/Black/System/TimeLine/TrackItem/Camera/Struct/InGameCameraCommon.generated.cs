//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class InGameCameraCommon : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int mode;
		public int startEndBlendMode_;
		public bool isCheckCollision_;
		[UnityEngine.SerializeReference] public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCollision collisionData_;
		public bool isEnableCancelWhenPCFrameOut_;
		public bool isEnableCancelWhenTerribleCollieded_;
		public bool isCutChangeOrder;
		public bool isNeedClearCameraContainerBlendDataWhenCutChange_;
		public bool isUseBattleAssistRotationWhenNotControlingYaw_;
		public bool isIgnoreCameraShake_;
		public int autoCompositionShotType_;
		public bool isNeedCaptureForOtherRelativeTarget_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraCommon();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCommon", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCommon.ObjectType, Construct, properties, 0, 80);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCommon", base.GetFieldProperties(), 1242605330, 1235712562);
            
			fieldProperties.AddIndirectlyProperty(new Property("collisionData_.checkCollisionType_", 2966151751, "Black.Camera.CheckCollisionType", 32, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("collisionData_.isNeedCheckFocusFromPC_", 1664994796, "bool", 36, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("collisionData_.isNeedCheckAdjustPog_", 324970790, "bool", 37, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("collisionData_.isNeedCheckGroundHeight_", 2274167939, "bool", 38, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("collisionData_.groundCheckMarginHeight_", 3426369923, "float", 40, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("collisionData_.groundCheckMinimumHeight_", 3274022027, "float", 44, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("collisionData_.isEnableCharaFadeOutWhenCollidedByCamera_", 3731041159, "bool", 48, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("collisionData_.isEnablePCFadeWhenCollidedByCamera_", 2619458363, "bool", 49, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("collisionData_.isUsePCFaseFadeWhenCollidedByCamera_", 1318026544, "bool", 50, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("collisionData_.isUseAdjustFadeMinPowerWhenCollidedByCamera_", 4216956902, "bool", 51, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("collisionData_.charaFadeByCameraSphereRadius_", 3793053227, "float", 52, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("collisionData_.isEndBlendCheckCollision_", 1923790695, "bool", 56, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("collisionData_.endBlendCheckCollisionType_", 2147232235, "Black.Camera.CheckCollisionType", 60, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("mode", 3966689298, "Black.Camera.InGameSeamlessTargetMode", 8, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("startEndBlendMode_", 723897861, "Black.Camera.SeamlessInGameSeparateStartEndBlendMode", 12, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCheckCollision_", 1357258370, "bool", 16, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("collisionData_", 1610769336, "Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCollision", 24, 40, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnableCancelWhenPCFrameOut_", 2316588487, "bool", 64, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isEnableCancelWhenTerribleCollieded_", 3169225281, "bool", 65, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCutChangeOrder", 3243753193, "bool", 66, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNeedClearCameraContainerBlendDataWhenCutChange_", 2284833010, "bool", 67, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseBattleAssistRotationWhenNotControlingYaw_", 3110327259, "bool", 68, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isIgnoreCameraShake_", 2675112431, "bool", 69, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("autoCompositionShotType_", 932543529, "Black.Camera.AutoCompositionShotType", 72, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNeedCaptureForOtherRelativeTarget_", 4141653000, "bool", 76, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new InGameCameraCommon();
        }
		
    }
}