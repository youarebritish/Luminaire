using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.ScreenEffect
{
    public partial class SequenceActionSetBokeh : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enabled_;
		public int filterLevel_;
		public bool enabledFilterLevel_;
		public bool enableWeather_;
		public int bokehShape_;
		public float bokehShapeRotation_;
		public float foculLength_;
		public float fNumber_;
		public float focalPlane_;
		public float focalPlaneRadius_;
		public float nearCoCMultiplier_;
		public float farCoCMultiplier_;
		public float maxCoCSizeNear_;
		public float maxCoCSizeFar_;
		public bool vignetteBlur_enabled_;
		public float vignetteBlur_yScale_;
		public float vignetteBlur_start_;
		public float vignetteBlur_strength_;
		public float vignetteBlur_power_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin focalPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_bokehShapeRotation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_foculLength_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_fNumber_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_focalPlaneRadius_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_nearCoCMultiplier_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_farCoCMultiplier_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_maxCoCSizeNear_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_maxCoCSizeFar_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_vignetteBlur_yScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_vignetteBlur_start_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_vignetteBlur_strength_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pin_vignetteBlur_power_;
		public int debugMode_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetBokeh();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.ScreenEffect.SequenceActionSetBokeh", 0, Black.Sequence.ScreenEffect.SequenceActionSetBokeh.ObjectType, null, properties, 0, 1592);
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

            fieldProperties = new PropertyContainer("Black.Sequence.ScreenEffect.SequenceActionSetBokeh", base.GetFieldProperties(), -1520417657, -787462767);
            return fieldProperties;
        }

		
    }
}