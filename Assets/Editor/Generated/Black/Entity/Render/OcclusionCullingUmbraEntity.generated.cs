using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Render
{
    public partial class OcclusionCullingUmbraEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string umbraFilePath_;
		public bool shadowEnable_;
		public bool useDefaultParameters_;
		public float smallestHole_;
		public float occlusionRadius_;
		public float smallestOccluder_;
		public float backfaceLimit_;
		public bool useDefaultViewVolume_;
		public UnityEngine.Vector4 viewVolumeMin_;
		public UnityEngine.Vector4 viewVolumeMax_;
		public bool autoAdjustViewVolume_;
		public UnityEngine.Vector4 viewVolumeSizeOffset_;
		public int idForGlobalIdentify_;
		public bool outputSceneFile_;
		public bool deleteUsdlFile_;
		public bool triggerEnable_;
		public int triggerType_;
		public float triggerRadius_;
		public float triggerHeight_;
		public float triggerWidth_;
		public float triggerDepth_;
		public float unloadMargin_;
		public UnityEngine.Vector4 triggerOffset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new OcclusionCullingUmbraEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Render.OcclusionCullingUmbraEntity", 0, Black.Entity.Render.OcclusionCullingUmbraEntity.ObjectType, null, properties, 0, 752);
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

            fieldProperties = new PropertyContainer("Black.Entity.Render.OcclusionCullingUmbraEntity", base.GetFieldProperties(), 684501425, 887228038);
            return fieldProperties;
        }

		
    }
}