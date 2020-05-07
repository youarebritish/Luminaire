using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionCameraRotation : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int isModifyYaw_;
		public float yaw_;
		public int isModifyTilt_;
		public float tilt_;
		public int isModifyRoll_;
		public float roll_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin yawPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin tiltPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rollPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotationPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraRotation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionCameraRotation", 0, Black.Sequence.Action.Camera.SequenceActionCameraRotation.ObjectType, null, properties, 0, 744);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionCameraRotation", base.GetFieldProperties(), 593366555, 63131260);
            
			
			
			return fieldProperties;
        }

		
    }
}