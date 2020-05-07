using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionCameraLockRotation : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool isLockYaw_;
		public float yaw_;
		public bool isLockTilt_;
		public float tilt_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin yawPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin tiltPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotationPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraLockRotation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionCameraLockRotation", 0, Black.Sequence.Action.Camera.SequenceActionCameraLockRotation.ObjectType, null, properties, 0, 744);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionCameraLockRotation", base.GetFieldProperties(), 655711396, 266481991);
            
			
			
			return fieldProperties;
        }

		
    }
}