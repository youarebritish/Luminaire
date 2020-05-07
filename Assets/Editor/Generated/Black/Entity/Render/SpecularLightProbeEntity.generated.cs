using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Render
{
    public partial class SpecularLightProbeEntity : Black.Entity.Render.LightProbeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public bool boxShape_;
		public bool useNewFadingControl_;
		public float power_;
		public bool renderDebug_;
		public bool renderInfluence_;
		public bool detatchCaptureBox_;
		public float captureRadius_;
		public UnityEngine.Vector4 captureBoxPosition_;
		public UnityEngine.Vector4 captureBoxRotation_;
		public UnityEngine.Vector4 captureBoxScale_;
		public bool setCaptureToInfluence_;
		public float useDirLightShadow_;
		public string sourceDirectory_;
		public string sourceFileName_;
		public float captureZNear_;
		public float captureZFar_;
		public int capturingOption_;
		public float captureAmbientScale_;
		public bool captureNow_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SpecularLightProbeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Render.SpecularLightProbeEntity", 0, Black.Entity.Render.SpecularLightProbeEntity.ObjectType, null, properties, 0, 720);
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

            fieldProperties = new PropertyContainer("Black.Entity.Render.SpecularLightProbeEntity", base.GetFieldProperties(), -123102586, 996350082);
            
			
			
			return fieldProperties;
        }

		
    }
}