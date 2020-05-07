using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Render
{
    public partial class LightProbeEntityBase : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 scaling_;
		public bool indoor_;
		public bool oceanOnly_;
		public int blendLayer_;
		public int probeMaskType_;
		public UnityEngine.Vector4 fadeLengthXZ_;
		public UnityEngine.Vector4 fadeLengthY_;
		public float radius_;
		public float interpolationRadius_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LightProbeEntityBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Render.LightProbeEntityBase", 0, Black.Entity.Render.LightProbeEntityBase.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.Entity.Render.LightProbeEntityBase", base.GetFieldProperties(), 1380648887, -675135130);
            return fieldProperties;
        }

		
    }
}