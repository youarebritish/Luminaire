using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.WorldMap
{
    public partial class TerrainAbsorbModelEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string sourcePath_;
		public float scaling_;
		public bool visible_;
		public bool isAbsorbTarget_;
		public float interpolationRange_;
		public int interpolationType_;
		public int interpolationFunction_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TerrainAbsorbModelEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.WorldMap.TerrainAbsorbModelEntity", 0, Black.Entity.WorldMap.TerrainAbsorbModelEntity.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.Entity.WorldMap.TerrainAbsorbModelEntity", base.GetFieldProperties(), 1093032320, 2027689440);
            
			
			
			return fieldProperties;
        }

		
    }
}