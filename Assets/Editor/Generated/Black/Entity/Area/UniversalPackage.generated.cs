using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Area
{
    public partial class UniversalPackage : Black.Entity.Area.LoadUnitPackage
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new UniversalPackage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Area.UniversalPackage", 0, Black.Entity.Area.UniversalPackage.ObjectType, null, properties, 0, 688);
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

            fieldProperties = new PropertyContainer("Black.Entity.Area.UniversalPackage", base.GetFieldProperties(), 11540728, 1680011362);
            return fieldProperties;
        }

		
    }
}