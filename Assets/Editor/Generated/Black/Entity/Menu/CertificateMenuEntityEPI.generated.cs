using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class CertificateMenuEntityEPI : Black.Entity.Menu.CertificateMenuEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CertificateMenuEntityEPI();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.CertificateMenuEntityEPI", 0, Black.Entity.Menu.CertificateMenuEntityEPI.ObjectType, null, properties, 0, 3712);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.CertificateMenuEntityEPI", base.GetFieldProperties(), 592886641, -2121152643);
            
			
			
			return fieldProperties;
        }

		
    }
}