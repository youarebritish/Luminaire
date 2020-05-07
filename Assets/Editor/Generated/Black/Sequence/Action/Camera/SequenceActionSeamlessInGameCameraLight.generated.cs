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
            
			fieldProperties.AddProperty(new Property("endBlendTimePin_", 472028264, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2400, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endBlendCutChangePin_", 3368437951, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2488, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startBlendTimePin_", 2612906267, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2576, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startBlendCutChangePin_", 2511695770, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2664, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastKeepPin_", 1115254540, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2752, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fovPin_", 1724197964, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2840, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnRollPlusSignPin_", 872753220, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2928, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnRollPin_", 101198145, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3016, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnTiltAddDegPin_", 2978613404, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3104, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnTiltPin_", 3019476029, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3192, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnYawPlusSignPin_", 185187356, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3280, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnYawAddDegPin_", 4201173072, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnYawPin_", 1143598217, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("relativeTargetPin_", 3876791728, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3544, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("povDistancePin_", 1542489141, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3632, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pogSignPin_", 357292196, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3720, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetOffsetPin_", 547031159, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3808, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetMatrixPin_", 369924909, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3896, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetPin_", 4111270248, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 3984, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}