using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.ScreenEffect
{
    public partial class SequenceActionSetVWGlare : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enabled_;
		public bool enableWeather_;
		public float gammaSpace_;
		public float softAmount_;
		public float softExpand_;
		public float foggyAmount_;
		public float foggyExpand_;
		public bool useColoring_;
		public float soft_r_;
		public float soft_g_;
		public float soft_b_;
		public float foggy_r_;
		public float foggy_g_;
		public float foggy_b_;
		public float sparkBlend_;
		public float sparkAttenuation_;
		public int sparkShape_;
		public float sparkRotation_;
		public bool useSparkColoring_;
		public float spark_r_;
		public float spark_g_;
		public float spark_b_;
		public bool debugGraph_;
		public int debugIndex_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enabled_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin softAmount_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin softExpand_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foggyAmount_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foggyExpand_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin useColoring_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin soft_r_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin soft_g_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin soft_b_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foggy_r_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foggy_g_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin foggy_b_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sparkBlend_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sparkAttenuation_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sparkShape_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin sparkRotation_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin useSparkColoring_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spark_r_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spark_g_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spark_b_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVWGlare();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.ScreenEffect.SequenceActionSetVWGlare", 0, Black.Sequence.ScreenEffect.SequenceActionSetVWGlare.ObjectType, null, properties, 0, 2312);
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

            fieldProperties = new PropertyContainer("Black.Sequence.ScreenEffect.SequenceActionSetVWGlare", base.GetFieldProperties(), 1921943561, -421546516);
            return fieldProperties;
        }

		
    }
}