using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Level
{
    public partial class PointWind : Black.Entity.Level.RangedWindBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float m_Radius;
		public float m_InterpolationRadius;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PointWind();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Level.PointWind", 0, Black.Entity.Level.PointWind.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Entity.Level.PointWind", base.GetFieldProperties(), 1940173458, 1733529070);
            
			
			
			return fieldProperties;
        }

		
    }
}