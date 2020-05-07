using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Entity.Prefab
{
    public partial class Prefab : SQEX.Ebony.Framework.Entity.EntityPackage
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new Prefab();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Entity.Prefab.Prefab", 0, SQEX.Ebony.Framework.Entity.Prefab.Prefab.ObjectType, null, properties, 8, 592);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Entity.Prefab.Prefab", base.GetFieldProperties(), 773884001, -1826627268);
            
			
			
			return fieldProperties;
        }

		
    }
}