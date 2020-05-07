using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity
{
    public partial class OceanParameter : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int waveIntensityLevel_;
		public UnityEngine.Vector4 fftOctave0Params0_;
		public UnityEngine.Vector4 fftOctave0Params1_;
		public UnityEngine.Vector4 fftOctave1Params0_;
		public UnityEngine.Vector4 fftOctave1Params1_;
		public UnityEngine.Vector4 foamParams_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new OceanParameter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.OceanParameter", 0, Black.Entity.OceanParameter.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("Black.Entity.OceanParameter", base.GetFieldProperties(), 432306394, -698696659);
            
			
			
			return fieldProperties;
        }

		
    }
}