using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionCameraGetYawLimit : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin yawMinPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin yawMaxPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cameraPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraGetYawLimit();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionCameraGetYawLimit", 0, Black.Sequence.Action.Camera.SequenceActionCameraGetYawLimit.ObjectType, null, properties, 0, 632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionCameraGetYawLimit", base.GetFieldProperties(), 2077768065, 1229177465);
            return fieldProperties;
        }

		
    }
}