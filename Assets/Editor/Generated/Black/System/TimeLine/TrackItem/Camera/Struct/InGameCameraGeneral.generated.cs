using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraGeneral : Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneralBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float backToNormalCameraTime1_;
		public float backToNormalCameraTime2_;
		public bool isBackToDefaultYaw_;
		public float backToDefaultYawInterpSpeed_;
		public bool isBackToDefaultTilt_;
		public float backToDefaultTiltInterpSpeed_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraGeneral();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneral", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneral.ObjectType, null, properties, 0, 200);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraGeneral", base.GetFieldProperties(), 242251281, 1124349367);
            return fieldProperties;
        }

		
    }
}