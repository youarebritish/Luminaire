using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraCollision : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int checkCollisionType_;
		public bool isNeedCheckFocusFromPC_;
		public bool isNeedCheckAdjustPog_;
		public bool isNeedCheckGroundHeight_;
		public float groundCheckMarginHeight_;
		public float groundCheckMinimumHeight_;
		public bool isEnableCharaFadeOutWhenCollidedByCamera_;
		public bool isEnablePCFadeWhenCollidedByCamera_;
		public bool isUsePCFaseFadeWhenCollidedByCamera_;
		public bool isUseAdjustFadeMinPowerWhenCollidedByCamera_;
		public float charaFadeByCameraSphereRadius_;
		public bool isEndBlendCheckCollision_;
		public int endBlendCheckCollisionType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraCollision();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCollision", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCollision.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraCollision", base.GetFieldProperties(), -1975832595, 536296909);
            return fieldProperties;
        }

		
    }
}