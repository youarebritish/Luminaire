using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Render
{
    public partial class SequenceActionSetOcean : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin interpolationTimePin_;
		public bool enableOcean_;
		public bool enableQueryRipple_;
		public bool enableQueryFlowMap_;
		public string oceanMaterialPath_;
		public float interpolationTime_;
		public bool forceSyncRender_;
		public UnityEngine.Vector4 mipmapLod_;
		public float projectedGridCameraOffset_;
		public float suppressionLerpStartRadius_;
		public float suppressionLerpEndRadius_;
		public float suppressionMinFactor_;
		public float drawableAABBScale_;
		public int drawPriority_;
		public float fftWindDirection_;
		public float fftWavePatchLengthNear_;
		public float fftWavePatchLengthFar_;
		public float flowMapTimeInterval_;
		public float flowMapMaxOffset_;
		public float waveIntensityLevel_;
		public IList<Black.Entity.OceanParameter> oceanParamPresets_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetOcean();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Render.SequenceActionSetOcean", 0, Black.Sequence.Render.SequenceActionSetOcean.ObjectType, null, properties, 0, 832);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Render.SequenceActionSetOcean", base.GetFieldProperties(), -1810532324, 1641367024);
            return fieldProperties;
        }

		
    }
}