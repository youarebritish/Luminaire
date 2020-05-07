using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraTurn : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isOverrideLockOnLayer_;
		public bool isUseLockOnTurn_;
		public bool isUseLockOnTurnTilt_;
		public Black.Camera.Struct.CameraControlTurn controlTurn_;
		public Black.Camera.Struct.CameraAngleLimit angleLimit_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraTurn();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurn", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurn.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurn", base.GetFieldProperties(), -122247259, -1717097140);
            
			
			
			return fieldProperties;
        }

		
    }
}