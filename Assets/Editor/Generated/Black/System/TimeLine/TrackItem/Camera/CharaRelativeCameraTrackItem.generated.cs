using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera
{
    public partial class CharaRelativeCameraTrackItem : Black.System.TimeLine.TrackItem.CameraCCFTrackItem
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isAddPog_;
		public bool isAddPov_;
		public bool isAddUp_;
		public uint baseElementId_;
		public bool isCalcTilt_;
		public bool isCalcRoll_;
		public bool bIsAttach_;
		public UnityEngine.Vector4 relativeOffset_;
		public UnityEngine.Vector4 relativeRotation_;
		public bool isCheckCollision_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.CharaRelativeCameraCollision collisionOpt_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CharaRelativeCameraTrackItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.CharaRelativeCameraTrackItem", 0, Black.System.TimeLine.TrackItem.Camera.CharaRelativeCameraTrackItem.ObjectType, null, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.CharaRelativeCameraTrackItem", base.GetFieldProperties(), 209008462, -1315130045);
            return fieldProperties;
        }

		
    }
}