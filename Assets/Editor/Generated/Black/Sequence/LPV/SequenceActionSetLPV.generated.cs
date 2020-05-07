using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.LPV
{
    public partial class SequenceActionSetLPV : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool enabled_;
		public float nearPlane_;
		public float farPlane_;
		public float splitExp_;
		public float startFadeRatio1_;
		public float endFadeRatio1_;
		public float startFadeRatio2_;
		public float endFadeRatio2_;
		public float addInitialVPLFactor_;
		public float vplStrengthPerUnitArea1_;
		public float vplStrengthPerUnitArea2_;
		public float vplStrengthPerUnitArea3_;
		public float propagationMult1_;
		public float propagationMult2_;
		public float propagationMult3_;
		public bool enableBlocker_;
		public float blockerStrengthPerUnitArea_;
		public float colorScaleR_;
		public float colorScaleG_;
		public float colorScaleB_;
		public float blendTime1_;
		public float blendTime2_;
		public float blendTime3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enabled_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin nearPlane_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin farPlane_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin splitExp_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin startFadeRatio1_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin endFadeRatio1_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin startFadeRatio2_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin endFadeRatio2_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin addInitialVPLFactor_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin vplStrengthPerUnitArea1_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin vplStrengthPerUnitArea2_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin vplStrengthPerUnitArea3_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin propagationMult1_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin propagationMult2_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin propagationMult3_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enableBlocker_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blockerStrengthPerUnitArea_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin colorScaleR_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin colorScaleG_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin colorScaleB_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blendTime1_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blendTime2_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blendTime3_pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetLPV();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.LPV.SequenceActionSetLPV", 0, Black.Sequence.LPV.SequenceActionSetLPV.ObjectType, null, properties, 0, 2488);
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

            fieldProperties = new PropertyContainer("Black.Sequence.LPV.SequenceActionSetLPV", base.GetFieldProperties(), -1122550160, -2022821942);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_", 1722022099, "bool", 368, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("nearPlane_", 389379704, "float", 372, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("farPlane_", 1247414877, "float", 376, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("splitExp_", 1723438383, "float", 380, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("startFadeRatio1_", 3582084716, "float", 384, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("endFadeRatio1_", 4039154407, "float", 388, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("startFadeRatio2_", 2508464195, "float", 392, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("endFadeRatio2_", 817704464, "float", 396, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("addInitialVPLFactor_", 1939508810, "float", 400, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vplStrengthPerUnitArea1_", 2879349072, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vplStrengthPerUnitArea2_", 1805728551, "float", 408, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("vplStrengthPerUnitArea3_", 1805875646, "float", 412, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propagationMult1_", 2738235267, "float", 416, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propagationMult2_", 3811752620, "float", 420, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("propagationMult3_", 3811605525, "float", 424, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableBlocker_", 1315059253, "bool", 428, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("blockerStrengthPerUnitArea_", 254004641, "float", 432, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("colorScaleR_", 2690438021, "float", 436, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("colorScaleG_", 3767604136, "float", 440, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("colorScaleB_", 2693101045, "float", 444, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blendTime1_", 1843395437, "float", 448, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blendTime2_", 770069106, "float", 452, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("blendTime3_", 769922011, "float", 456, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("enabled_pin_", 3058841247, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("nearPlane_pin_", 1180141560, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 552, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("farPlane_pin_", 1200587769, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 640, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("splitExp_pin_", 3502902779, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 728, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startFadeRatio1_pin_", 2869768252, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 816, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endFadeRatio1_pin_", 2695753411, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 904, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("startFadeRatio2_pin_", 4122556879, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 992, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("endFadeRatio2_pin_", 1383010304, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1080, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("addInitialVPLFactor_pin_", 322368778, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1168, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("vplStrengthPerUnitArea1_pin_", 3973449536, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1256, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("vplStrengthPerUnitArea2_pin_", 3222025219, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1344, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("vplStrengthPerUnitArea3_pin_", 3305108670, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1432, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("propagationMult1_pin_", 4161408527, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1520, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("propagationMult2_pin_", 526579324, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1608, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("propagationMult3_pin_", 3170513441, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1696, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableBlocker_pin_", 921484929, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1784, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blockerStrengthPerUnitArea_pin_", 978559325, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1872, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("colorScaleR_pin_", 378608721, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1960, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("colorScaleG_pin_", 1916836264, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2048, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("colorScaleB_pin_", 1152977473, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2136, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blendTime1_pin_", 3681510537, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2224, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blendTime2_pin_", 375144866, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2312, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("blendTime3_pin_", 3278832439, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2400, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}