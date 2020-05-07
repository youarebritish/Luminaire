using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Render
{
    public partial class SequenceActionSetOceanIndividualSetting : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int paramType_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enableOceanPin_;
		public bool enableOcean_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin projectedGridCameraOffsetPin_;
		public float projectedGridCameraOffset_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin suppressionLerpStartRadiusPin_;
		public float suppressionLerpStartRadius_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin suppressionLerpEndRadiusPin_;
		public float suppressionLerpEndRadius_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin suppressionMinFactorPin_;
		public float suppressionMinFactor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin drawableAABBScalePin_;
		public float drawableAABBScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin drawPriorityPin_;
		public int drawPriority_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fftWindDirectionPin_;
		public float fftWindDirection_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mipmapLodMinPin_;
		public float mipmapLodMin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mipmapLodMaxPin_;
		public float mipmapLodMax_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mipmapLodBiasPin_;
		public float mipmapLodBias_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin meshLodPin_;
		public int meshLod_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fillHolePin_;
		public bool fillHole_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetOceanIndividualSetting();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Render.SequenceActionSetOceanIndividualSetting", 0, Black.Sequence.Render.SequenceActionSetOceanIndividualSetting.ObjectType, null, properties, 0, 1624);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Render.SequenceActionSetOceanIndividualSetting", base.GetFieldProperties(), -1019367152, 1982178230);
            return fieldProperties;
        }

		
    }
}