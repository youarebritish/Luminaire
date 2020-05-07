using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.ScreenEffect
{
    public partial class SequenceActionSetVWGlare2 : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
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
		public Black.Sequence.ScreenEffect.VWGlareFilterSequenceData masterData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetVWGlare2();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.ScreenEffect.SequenceActionSetVWGlare2", 0, Black.Sequence.ScreenEffect.SequenceActionSetVWGlare2.ObjectType, null, properties, 0, 2320);
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

            fieldProperties = new PropertyContainer("Black.Sequence.ScreenEffect.SequenceActionSetVWGlare2", base.GetFieldProperties(), 725916156, 203152158);
            return fieldProperties;
        }

		
    }
}