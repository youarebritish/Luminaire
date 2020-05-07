using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Level
{
    public partial class BoxWind : Black.Entity.Level.RangedWindBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 m_Range;
		public UnityEngine.Vector4 m_InterpolationRange;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BoxWind();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Level.BoxWind", 0, Black.Entity.Level.BoxWind.ObjectType, null, properties, 0, 480);
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

            fieldProperties = new PropertyContainer("Black.Entity.Level.BoxWind", base.GetFieldProperties(), -1729368663, 747926542);
            return fieldProperties;
        }

		
    }
}