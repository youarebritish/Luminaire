using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Corps
{
    public partial class CorpsPackage : Black.Entity.Actor.ActorPackageBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CorpsPackage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Corps.CorpsPackage", 0, Black.Entity.Corps.CorpsPackage.ObjectType, null, properties, 0, 624);
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

            fieldProperties = new PropertyContainer("Black.Entity.Corps.CorpsPackage", base.GetFieldProperties(), -66811024, 939804726);
            return fieldProperties;
        }

		
    }
}