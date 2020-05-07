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
            return fieldProperties;
        }

		
    }
}