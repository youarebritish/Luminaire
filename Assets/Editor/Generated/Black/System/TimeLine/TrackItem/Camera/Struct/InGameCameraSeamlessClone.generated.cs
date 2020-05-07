using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraSeamlessClone : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int backToSeamlessCloneReleasePreset_;
		public int backToNormalCoordInterpType_;
		public float backToNormalInterpTime_;
		public float backToNormalCameraTime1_;
		public float backToNormalCameraTime2_;
		public float backToNormalCameraAccel_;
		public int backToNormalInterpBlendMode_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraSeamlessClone();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone", base.GetFieldProperties(), 1348943769, -1858667549);
            
			
			
			return fieldProperties;
        }

		
    }
}