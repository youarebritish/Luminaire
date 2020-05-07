using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionSeamlessInGameCameraLight : Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraBase
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
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin povDistancePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pogSignPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetOffsetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetMatrixPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSeamlessInGameCameraLight();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraLight", 0, Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraLight.ObjectType, null, properties, 0, 4080);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraLight", base.GetFieldProperties(), -464393529, 910045975);
            
			
			
			return fieldProperties;
        }

		
    }
}