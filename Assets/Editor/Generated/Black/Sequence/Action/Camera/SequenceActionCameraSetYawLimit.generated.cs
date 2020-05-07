using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionCameraSetYawLimit : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin resetPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin yawMinPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin yawMaxPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cameraPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin relativeActorPin_;
		public float offsetYawAngle_;
		public float yawMin_;
		public float yawMax_;
		public bool isUseInterp_;
		public float interpSpeed_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraSetYawLimit();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionCameraSetYawLimit", 0, Black.Sequence.Action.Camera.SequenceActionCameraSetYawLimit.ObjectType, null, properties, 0, 840);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionCameraSetYawLimit", base.GetFieldProperties(), 1225013634, -1955706809);
            return fieldProperties;
        }

		
    }
}