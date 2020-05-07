using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Camera.Struct
{
    public partial class InGameCameraPog : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int lockOnType_;
		public int actorBaseType_;
		public int lockOnActorOffsetType_;
		public uint boneId_;
		public int coordInterpType_;
		public float pogInterpTime_;
		public int pogTimeInterpMode_;
		public float pogVelocity_;
		public bool isUpdateYDirectly_;
		public float pogDirectionYVelocity_;
		public int matrixType_;
		public int offsetType_;
		public UnityEngine.Vector4 pogOffset_;
		public bool isUseAddOffsetXByProjectionBetweenPCandTarget_;
		public float addOffsetXSabunMultiplyRate_;
		public float addOffsetXMaxLimit_;
		public bool isUpdateXEveryFrame_;
		public bool isUpdateYEveryFrame__;
		public bool isUpdateZEveryFrame_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameCameraPog();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPog", 0, Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPog.ObjectType, null, properties, 0, 112);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraPog", base.GetFieldProperties(), -2009302530, 1169079133);
            return fieldProperties;
        }

		
    }
}