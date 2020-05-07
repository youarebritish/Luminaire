using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine
{
    public partial class SequenceActionTimeLineTPRailCameraTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackInterpBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float interpSpeedFromGameCamera_;
		public bool isUseEachKeyRailValidAreaWidth_;
		public float railValidAreaWidth_;
		public Black.Camera.Struct.CameraControlTurn controlTurn_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineTPRailCameraTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.SequenceActionTimeLineTPRailCameraTrack", 0, Black.Sequence.Action.TimeLine.SequenceActionTimeLineTPRailCameraTrack.ObjectType, null, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.SequenceActionTimeLineTPRailCameraTrack", base.GetFieldProperties(), 1616473513, 926193808);
            
			fieldProperties.AddProperty(new Property("interpSpeedFromGameCamera_", 3084207648, "float", 352, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseEachKeyRailValidAreaWidth_", 2954507046, "bool", 356, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("railValidAreaWidth_", 848066077, "float", 360, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("controlTurn_", 764311870, "Black.Camera.Struct.CameraControlTurn", 368, 56, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}