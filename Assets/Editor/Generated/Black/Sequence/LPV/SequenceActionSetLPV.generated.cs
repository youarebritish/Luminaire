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
            return fieldProperties;
        }

		
    }
}