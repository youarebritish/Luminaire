using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraTurnYaw : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isUse_;
		public int rotationUseValueTypeYaw_;
		public bool isNotControllingYawWhenBattleHybridAndOverride_;
		public int bestAngleJudgeType_;
		public int turnInterpType_;
		public int turnTimeInterpMode_;
		public int rotationDirection_;
		public bool isCalcAlwaysBehindPC_;
		public bool isUpdateTurnEveryFrame_;
		public int rotationSetAngleType_;
		public float turnInterpTimeYaw_;
		public float turnVelocityYaw_;
		public float turnYaw_;
		public bool isAllowUserControlTurn_;
		public int stealingPlayerDirectionInterpType_;
		public float stealingPlayerDirectionInterpVelocity_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraTurnYaw();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYaw", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYaw.ObjectType, null, properties, 0, 72);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnYaw", base.GetFieldProperties(), 205736526, -2080539401);
            
			
			
			return fieldProperties;
        }

		
    }
}