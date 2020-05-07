using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class CharaRelativeCameraCollision : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float rayLength_;
		public float rayOptionalFov_;
		public float rayOptionalY_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CharaRelativeCameraCollision();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.CharaRelativeCameraCollision", 0, Black.System.TimeLine.TrackItem.Camera.Struct.CharaRelativeCameraCollision.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.CharaRelativeCameraCollision", base.GetFieldProperties(), -1599446275, -964893496);
            
			
			
			return fieldProperties;
        }

		
    }
}