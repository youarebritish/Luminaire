using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.WorldMap
{
    public partial class TerrainCurveData : Black.WorldMap.TerrainCurveDataData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int ModelSetCount_;
		public IList<char> ModelName_;
		public IList<int> ModelIndex0_;
		public IList<int> ModelIndex1_;
		public IList<int> ModelIndex2_;
		public IList<int> ModelIndex0Count_;
		public IList<float> ModelLength0_;
		public IList<float> ModelLength1_;
		public IList<float> ModelLength2_;
		public IList<float> OffsetX_;
		public IList<float> OffsetY_;
		public IList<bool> IsCollision_;
		public IList<bool> IsTransForm_;
		public IList<bool> IsStraight_;
		public IList<bool> IsYRotationOnly_;
		public IList<bool> IsForInstancing_;
		public IList<int> ModelSelectRate0_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TerrainCurveData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.WorldMap.TerrainCurveData", 0, Black.WorldMap.TerrainCurveData.ObjectType, null, properties, 0, 1344);
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

            fieldProperties = new PropertyContainer("Black.WorldMap.TerrainCurveData", base.GetFieldProperties(), -557088140, 1693118458);
            
			
			
			return fieldProperties;
        }

		
    }
}