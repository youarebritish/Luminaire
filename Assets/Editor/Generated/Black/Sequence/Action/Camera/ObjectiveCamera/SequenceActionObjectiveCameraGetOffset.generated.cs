using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera.ObjectiveCamera
{
    public partial class SequenceActionObjectiveCameraGetOffset : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin eyeOffsetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin pogOffsetYPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin pogOffsetXPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin pogOffsetPin_;
		public int offsetType_;
		public int offsetGettingMode_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionObjectiveCameraGetOffset();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.ObjectiveCamera.SequenceActionObjectiveCameraGetOffset", 0, Black.Sequence.Action.Camera.ObjectiveCamera.SequenceActionObjectiveCameraGetOffset.ObjectType, null, properties, 0, 728);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.ObjectiveCamera.SequenceActionObjectiveCameraGetOffset", base.GetFieldProperties(), -1071540010, -574254991);
            
			
			
			return fieldProperties;
        }

		
    }
}