using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraTurnTilt : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isUse_;
		public int rotationUseValueTypeTilt_;
		public bool isUseDefaultValueWhenBattleHybridAndOverride_;
		public int turnInterpType_;
		public int turnTimeInterpMode_;
		public bool isUseAdjustAngle_;
		public bool isUpdateTurnEveryFrame_;
		public int rotationSetAngleType_;
		public float turnInterpTimeTilt_;
		public float turnVelocityTilt_;
		public float turnTilt_;
		public bool isAllowUserControlTurn_;
		public int stealingPlayerDirectionInterpType_;
		public float stealingPlayerDirectionInterpVelocity_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraTurnTilt();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTilt", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTilt.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnTilt", base.GetFieldProperties(), 978977602, 215167140);
            
			
			
			return fieldProperties;
        }

		
    }
}