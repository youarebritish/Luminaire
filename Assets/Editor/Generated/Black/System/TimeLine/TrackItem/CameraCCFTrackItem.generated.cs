using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem
{
    public partial class CameraCCFTrackItem : Black.System.TimeLine.TrackItem.BlendTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string sourcePath_;
		public float totalBaseFrame_;
		public bool isLoop_;
		public float speed_;
		public float startFrame_;
		public float endFrame_;
		public bool isEventSeamless_;
		public bool isInGameStateWhenSeamlessOut_;
		public int seamlessInterpMode_;
		public int seamlessInterpCloneReleaseMode_;
		public float seamlessInterpCloneAutoReleaseTime_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone seamlessCloneData_;
		public Black.Camera.Struct.CameraControlTurn seamlessInterpCloneControlTurn_;
		public bool isUseDefaultAngleLimitTiltAtEventSeamless_;
		public float seamlessInterpAngleLimitTiltMin_;
		public float seamlessInterpAngleLimitTiltMax_;
		public bool isSeamlessInterpCheckCollision_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CameraCCFTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.CameraCCFTrackItem", 0, Black.System.TimeLine.TrackItem.CameraCCFTrackItem.ObjectType, null, properties, 0, 344);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.CameraCCFTrackItem", base.GetFieldProperties(), -2039134296, -1030576884);
            
			
			
			return fieldProperties;
        }

		
    }
}