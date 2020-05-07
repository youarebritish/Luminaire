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
            
			fieldProperties.AddProperty(new Property("endBlendTimePin_", 472028264, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2400, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endBlendCutChangePin_", 3368437951, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2488, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startBlendTimePin_", 2612906267, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2576, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startBlendCutChangePin_", 2511695770, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2664, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastKeepPin_", 1115254540, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2752, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fovPin_", 1724197964, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2840, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnRollPlusSignPin_", 872753220, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2928, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnRollPin_", 101198145, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3016, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("relativeTargetPin_", 3876791728, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3104, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("povOffsetPin_", 847391761, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3192, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("povMatrixPin_", 3033582619, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3280, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("povTargetPin_", 4172336751, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pogSignPin_", 357292196, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pogOffsetPin_", 317626922, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3544, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pogMatrixPin_", 3731826716, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3632, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pogTargetPin_", 3524659752, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3720, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}