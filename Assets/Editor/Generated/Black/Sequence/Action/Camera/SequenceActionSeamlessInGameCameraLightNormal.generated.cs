using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionSeamlessInGameCameraLightNormal : Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin endBlendTimePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin endBlendCutChangePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin startBlendTimePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin startBlendCutChangePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin lastKeepPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fovPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnRollPlusSignPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnRollPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnTiltAddDegPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnTiltPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnYawPlusSignPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnYawAddDegPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnYawPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin relativeTargetPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSeamlessInGameCameraLightNormal();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraLightNormal", 0, Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraLightNormal.ObjectType, null, properties, 0, 3632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraLightNormal", base.GetFieldProperties(), 1136174386, -2033029164);
            return fieldProperties;
        }

		
    }
}