using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.ScreenEffect
{
    public partial class VWVignetteFilterSequenceData : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public bool enableWeather_;
		public float amount_;
		public float yScale_;
		public float cornerAttenuation_;
		public float corner_r_;
		public float corner_g_;
		public float corner_b_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VWVignetteFilterSequenceData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.ScreenEffect.VWVignetteFilterSequenceData", 0, Black.Sequence.ScreenEffect.VWVignetteFilterSequenceData.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.Sequence.ScreenEffect.VWVignetteFilterSequenceData", base.GetFieldProperties(), 1418410879, 587992316);
            return fieldProperties;
        }

		
    }
}