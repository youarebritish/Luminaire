using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraFovNew : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isUse_;
		public float fovCurveDegree_;
		public int fovUseValueType_;
		public int interpType_;
		public int timeInterpMode_;
		public int setFovType_;
		public float interpTime_;
		public float interpVelocity_;
		public float autoCompositionOverrideFov_;
		public bool isUpdateEveryFrame_;
		public bool isKeepFovFromLastSeamlessCamera_;
		public bool isIgnoreIncrementFov_;
		public int useCalculateFov_;
		public float maxTargetRaidus_;
		public float minTargetRaidus_;
		public float boundingSizeRate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraFovNew();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovNew", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovNew.ObjectType, null, properties, 0, 72);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraFovNew", base.GetFieldProperties(), -1371394372, -91568415);
            
			
			
			return fieldProperties;
        }

		
    }
}