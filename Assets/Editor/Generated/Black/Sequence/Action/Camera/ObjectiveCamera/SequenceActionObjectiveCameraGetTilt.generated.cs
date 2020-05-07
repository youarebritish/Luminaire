using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera.ObjectiveCamera
{
    public partial class SequenceActionObjectiveCameraGetTilt : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin tiltMinPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin tiltMaxPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cameraPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionObjectiveCameraGetTilt();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.ObjectiveCamera.SequenceActionObjectiveCameraGetTilt", 0, Black.Sequence.Action.Camera.ObjectiveCamera.SequenceActionObjectiveCameraGetTilt.ObjectType, null, properties, 0, 632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.ObjectiveCamera.SequenceActionObjectiveCameraGetTilt", base.GetFieldProperties(), -1484753619, 485809626);
            
			
			
			return fieldProperties;
        }

		
    }
}