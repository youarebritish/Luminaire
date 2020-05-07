using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.ScreenEffect
{
    public partial class VWGlareFilterSequenceData : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public bool enableWeather_;
		public float gammaSpace_;
		public float softAmount_;
		public float softExpand_;
		public float foggyAmount_;
		public float foggyExpand_;
		public bool useColoring_;
		public float soft_r_;
		public float soft_g_;
		public float soft_b_;
		public float foggy_r_;
		public float foggy_g_;
		public float foggy_b_;
		public float sparkBlend_;
		public float sparkAttenuation_;
		public int sparkShape_;
		public float sparkRotation_;
		public bool useSparkColoring_;
		public float spark_r_;
		public float spark_g_;
		public float spark_b_;
		public bool debugGraph_;
		public int debugIndex_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VWGlareFilterSequenceData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.ScreenEffect.VWGlareFilterSequenceData", 0, Black.Sequence.ScreenEffect.VWGlareFilterSequenceData.ObjectType, null, properties, 0, 104);
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

            fieldProperties = new PropertyContainer("Black.Sequence.ScreenEffect.VWGlareFilterSequenceData", base.GetFieldProperties(), 2008622319, -20028584);
            
			
			
			return fieldProperties;
        }

		
    }
}