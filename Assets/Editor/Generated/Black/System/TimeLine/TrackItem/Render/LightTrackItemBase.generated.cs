using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Render
{
    public partial class LightTrackItemBase : Black.System.TimeLine.TrackItem.ResourceTrackItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool mayaLightDirection_;
		public UnityEngine.Vector4 position_;
		public UnityEngine.Vector4 rotation_;
		public UnityEngine.Color color_;
		public float intensity_;
		public float radius_;
		public float range_;
		public bool shadowEnabled_;
		public int shadowResolution_;
		public float shadowZNear_;
		public float shadowSlopeBias_;
		public float shadowZBias_;
		public float shadowPower_;
		public bool chrOnlyShadow_;
		public string projectionSourcePath_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LightTrackItemBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Render.LightTrackItemBase", 0, Black.System.TimeLine.TrackItem.Render.LightTrackItemBase.ObjectType, null, properties, 0, 256);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Render.LightTrackItemBase", base.GetFieldProperties(), 1554071351, 2022202923);
            return fieldProperties;
        }

		
    }
}