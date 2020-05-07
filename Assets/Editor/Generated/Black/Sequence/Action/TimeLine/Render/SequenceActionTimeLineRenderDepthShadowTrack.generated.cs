using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render
{
    public partial class SequenceActionTimeLineRenderDepthShadowTrack : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public bool shadowCalcRadiusEnabled_;
		public bool shadowCullCheckMinEnabled_;
		public float zNear_;
		public float shadowDistance0_;
		public float shadowCullSize0_;
		public float shadowDistance1Near_;
		public float shadowDistance1_;
		public float shadowCullSize1_;
		public float shadowDistance2Near_;
		public float shadowDistance2_;
		public float shadowCullSize2_;
		public float shadowDistance3Near_;
		public float shadowDistance3_;
		public float shadowCullSize3_;
		public float depthBias_;
		public float depthCascadeFactor_;
		public float depthSlope_;
		public float normalBias_;
		public float dropRange_;
		public float dropRangeMode_;
		public int cascadeShadowCount_;
		public int shadowResolution_;
		public bool inverseShadowDepthCulling_;
		public float fadeFarValue_;
		public bool shadowYLimitEnabled_;
		public float shadowYLimit_;
		public bool freeCameraAngle_;
		public bool dirEnabled_;
		public float dirX_;
		public float dirY_;
		public float dirZ_;
		public float rotX_;
		public float rotY_;
		public float rotZ_;
		public int maxNumShadowedLights_;
		public Black.System.TimeLine.TrackItem.Render.DepthShadowTrackItem masterTrackItem_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineRenderDepthShadowTrack();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.SequenceActionTimeLineRenderDepthShadowTrack", 0, Black.Sequence.Action.TimeLine.Render.SequenceActionTimeLineRenderDepthShadowTrack.ObjectType, null, properties, 0, 544);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.SequenceActionTimeLineRenderDepthShadowTrack", base.GetFieldProperties(), 1968293322, -617474687);
            return fieldProperties;
        }

		
    }
}