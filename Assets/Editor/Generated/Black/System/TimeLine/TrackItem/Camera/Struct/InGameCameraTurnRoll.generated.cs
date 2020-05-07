using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraTurnRoll : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isUse_;
		public int rotationUseValueTypeRoll_;
		public int turnInterpType_;
		public int turnTimeInterpMode_;
		public bool isUpdateTurnEveryFrame_;
		public int rotationSetAngleType_;
		public float turnInterpTimeRoll_;
		public float turnVelocityRoll_;
		public float turnRoll_;
		public bool isUseOldRollDirection_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraTurnRoll();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRoll", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRoll.ObjectType, null, properties, 0, 56);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRoll", base.GetFieldProperties(), 197990924, -1802226242);
            return fieldProperties;
        }

		
    }
}