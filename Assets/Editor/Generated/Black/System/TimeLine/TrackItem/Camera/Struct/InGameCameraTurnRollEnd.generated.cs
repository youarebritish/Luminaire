using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraTurnRollEnd : Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnBlendBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isUse_;
		public int interpMode_;
		public float interpTime_;
		public float interpVelocity_;
		public float turnRoll_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraTurnRollEnd();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollEnd", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollEnd.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraTurnRollEnd", base.GetFieldProperties(), -1777947719, 595230543);
            
			
			
			return fieldProperties;
        }

		
    }
}