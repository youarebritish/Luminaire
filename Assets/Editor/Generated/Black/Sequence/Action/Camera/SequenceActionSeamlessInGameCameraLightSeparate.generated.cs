using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera
{
    public partial class SequenceActionSeamlessInGameCameraLightSeparate : Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraBase
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
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin relativeTargetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin povOffsetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin povMatrixPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin povTargetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pogSignPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pogOffsetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pogMatrixPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pogTargetPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSeamlessInGameCameraLightSeparate();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraLightSeparate", 0, Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraLightSeparate.ObjectType, null, properties, 0, 3808);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.SequenceActionSeamlessInGameCameraLightSeparate", base.GetFieldProperties(), -1930168271, 117481781);
            
			
			
			return fieldProperties;
        }

		
    }
}