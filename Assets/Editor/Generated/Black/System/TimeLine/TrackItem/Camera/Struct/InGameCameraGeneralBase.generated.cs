using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraGeneralBase : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int filterLevel_;
		public uint seamlessGroupId_;
		public string seamlessId_;
		public int stopFilterType_;
		public bool isEnableSwitchOtherCamera_;
		public bool isEnableForceStopOtherCamera_;
		public bool isEventSeamless_;
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

            var dummy = new InGameCameraGeneralBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralBase", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralBase.ObjectType, null, properties, 0, 176);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralBase", base.GetFieldProperties(), -1360307711, 882167849);
            
			
			
			return fieldProperties;
        }

		
    }
}