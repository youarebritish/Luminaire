using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraPov : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int lockOnType_;
		public int actorBaseType_;
		public int lockOnActorOffsetType_;
		public uint boneId_;
		public int autoCompositionBaseType_;
		public int autoCompositionUpdateType_;
		public int valueSettingType_;
		public float incEyeDistance_;
		public bool isDisableBattleAddDistance_;
		public int seamlessInGameFlameInAddDistanceCalcType_;
		public bool isDisableAroundStatusAddDistance_;
		public float addDistanceRate_;
		public bool isDisableAngleDiffBetweenCam2PCAddDistance_;
		public float overrideEyeDistance_;
		public float minimumGuaranteeEyeDistance_;
		public float povVelocity_;
		public int matrixType_;
		public UnityEngine.Vector4 povOffset_;
		public int offsetXValueType_;
		public int autoCompositionShotSize_;
		public int autoCompositionFovLevel_;
		public uint autoCompositionPovBoneId_;
		public float autoCompositionFlameHeightRate_;
		public float autoCompositionFlameHeightYawRate_;
		public bool isUpdateXEveryFrame_;
		public bool isUpdateYEveryFrame__;
		public bool isUpdateZEveryFrame_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraPov();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPov", base.GetFieldProperties(), -2009302515, 1513457985);
            
			
			
			return fieldProperties;
        }

		
    }
}