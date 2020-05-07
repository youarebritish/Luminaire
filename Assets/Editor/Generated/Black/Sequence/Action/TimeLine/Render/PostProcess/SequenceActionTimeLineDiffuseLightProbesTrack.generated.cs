using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render.PostProcess
{
    public partial class SequenceActionTimeLineDiffuseLightProbesTrack : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enablePRT_;
		public bool enableIrradiance_;
		public float intensity_;
		public float irradIntensity_;
		public UnityEngine.Color irradColor_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineDiffuseLightProbesTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineDiffuseLightProbesTrack", 0, Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineDiffuseLightProbesTrack.ObjectType, null, properties, 0, 384);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.PostProcess.SequenceActionTimeLineDiffuseLightProbesTrack", base.GetFieldProperties(), 1490173091, 1369031378);
            
			fieldProperties.AddProperty(new Property("enablePRT_", 2194915905, "bool", 336, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("enableIrradiance_", 1180802057, "bool", 337, 1, 1, Property.PrimitiveType.Bool, 0, (char)1));
			fieldProperties.AddProperty(new Property("intensity_", 1363281103, "float", 340, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("irradIntensity_", 838981167, "float", 344, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			fieldProperties.AddProperty(new Property("irradColor_", 1646083173, "Luminous.RenderInterface.Color", 352, 16, 1, Property.PrimitiveType.Color, 0, (char)1));
			
			
			return fieldProperties;
        }

		
    }
}