using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera.ObjectiveCamera
{
    public partial class SequenceActionObjectiveCameraOffset : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin eyeOffsetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pogOffsetYPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pogOffsetXPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pogOffsetPin_;
		public int offsetType_;
		public int isOverridePogOffsetX_;
		public float pogOffsetX_;
		public int isOverridePogOffsetY_;
		public float pogOffsetY_;
		public int isOverrideEyeOffset_;
		public float eyeOffset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionObjectiveCameraOffset();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.ObjectiveCamera.SequenceActionObjectiveCameraOffset", 0, Black.Sequence.Action.Camera.ObjectiveCamera.SequenceActionObjectiveCameraOffset.ObjectType, null, properties, 0, 752);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.ObjectiveCamera.SequenceActionObjectiveCameraOffset", base.GetFieldProperties(), -666970756, 635179435);
            
			
			
			return fieldProperties;
        }

		
    }
}