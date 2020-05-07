using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Level
{
    public partial class DirectionalWind : Black.Entity.Level.RangedWindBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new DirectionalWind();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Level.DirectionalWind", 0, Black.Entity.Level.DirectionalWind.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Entity.Level.DirectionalWind", base.GetFieldProperties(), 426729066, -829948568);
            return fieldProperties;
        }

		
    }
}