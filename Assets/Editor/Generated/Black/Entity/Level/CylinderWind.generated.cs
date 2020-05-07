using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Level
{
    public partial class CylinderWind : Black.Entity.Level.RangedWindBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float m_Radius;
		public float m_Length;
		public float m_InterpolationRadius;
		public float m_InterpolationLength;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CylinderWind();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Level.CylinderWind", 0, Black.Entity.Level.CylinderWind.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Entity.Level.CylinderWind", base.GetFieldProperties(), -753304651, 2062873200);
            return fieldProperties;
        }

		
    }
}