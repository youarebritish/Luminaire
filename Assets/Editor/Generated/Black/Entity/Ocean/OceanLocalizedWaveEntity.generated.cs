using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Ocean
{
    public partial class OceanLocalizedWaveEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 scaling_;
		public bool localizedWaveEnabled_;
		public float wavelength_;
		public float amplitude_;
		public float speed_;
		public float steepness_;
		public UnityEngine.Vector4 falloffStart_;
		public UnityEngine.Vector4 noiseParam_;
		public UnityEngine.Vector4 foamParam_;
		public bool reversedDirection_;
		public bool curved_;
		public float curveCenterOffset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new OceanLocalizedWaveEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Ocean.OceanLocalizedWaveEntity", 0, Black.Entity.Ocean.OceanLocalizedWaveEntity.ObjectType, null, properties, 0, 400);
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

            fieldProperties = new PropertyContainer("Black.Entity.Ocean.OceanLocalizedWaveEntity", base.GetFieldProperties(), 736611447, -276032441);
            return fieldProperties;
        }

		
    }
}