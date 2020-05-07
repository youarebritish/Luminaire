using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Render
{
    public partial class SequenceActionSetMainLight : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool isUseDirectionalRGBA;
		public UnityEngine.Color directionalColor_;
		public float directionalColor_r;
		public float directionalColor_g;
		public float directionalColor_b;
		public float directionalColor_a;
		public float directionalIntensity_;
		public UnityEngine.Vector4 directionalRotation_;
		public bool isUseAmbientRGBA;
		public UnityEngine.Color ambientColor_;
		public float ambientColor_r;
		public float ambientColor_g;
		public float ambientColor_b;
		public float ambientColor_a;
		public float ambientIntensity_;
		public float ambientSpecUseDirLightShadow_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientSpecUseDirLightShadow_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientIntensity_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientColor_a_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientColor_b_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientColor_g_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientColor_r_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ambientColor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin isUseAmbientRGBA_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin directionalRotationW_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin directionalRotationZ_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin directionalRotationY_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin directionalRotationX_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin directionalLightDir_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin directionalIntensity_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin directionalColor_a_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin directionalColor_b_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin directionalColor_g_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin directionalColor_r_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin directionalColor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin isUseDirectionalRGBA_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetMainLight();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Render.SequenceActionSetMainLight", 0, Black.Sequence.Render.SequenceActionSetMainLight.ObjectType, null, properties, 0, 2272);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Render.SequenceActionSetMainLight", base.GetFieldProperties(), -193703253, -320638784);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseDirectionalRGBA", 3663407190, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalColor_", 347234571, "Luminous.RenderInterface.Color", 384, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalColor_r", 231698811, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalColor_g", 13589764, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalColor_b", 4258224203, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalColor_a", 4275001822, "float", 412, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalIntensity_", 3480104993, "float", 416, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalRotation_", 1930901506, "Luminous.Math.VectorA", 432, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseAmbientRGBA", 1909136922, "bool", 448, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientColor_", 1965402543, "Luminous.RenderInterface.Color", 464, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientColor_r", 1196058343, "float", 480, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientColor_g", 843728344, "float", 484, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientColor_b", 927616439, "float", 488, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientColor_a", 944394058, "float", 492, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientIntensity_", 2595803605, "float", 496, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientSpecUseDirLightShadow_", 3869096279, "float", 500, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientSpecUseDirLightShadow_pin_", 195739059, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 504, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientIntensity_pin_", 320750305, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 592, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientColor_a_pin_", 781224731, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 680, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientColor_b_pin_", 3600003768, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 768, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientColor_g_pin_", 3664362577, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 856, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientColor_r_pin_", 907622824, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 944, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ambientColor_pin_", 3842173563, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1032, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseAmbientRGBA_pin_", 3420772331, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1120, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalRotationW_pin_", 487828331, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1208, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalRotationZ_pin_", 1830156306, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1296, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalRotationY_pin_", 12124537, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1384, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalRotationX_pin_", 937935380, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalLightDir_pin_", 927702201, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1560, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalIntensity_pin_", 998353885, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1648, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalColor_a_pin_", 1037829599, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1736, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalColor_b_pin_", 62759372, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1824, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalColor_g_pin_", 1703314109, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1912, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalColor_r_pin_", 1801742204, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2000, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("directionalColor_pin_", 1523276775, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2088, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUseDirectionalRGBA_pin_", 3778740679, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}