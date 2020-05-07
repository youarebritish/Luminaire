using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class CertificateMenuEntityEPP : Black.Entity.Menu.CertificateMenuEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CertificateMenuEntityEPP();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.CertificateMenuEntityEPP", 0, Black.Entity.Menu.CertificateMenuEntityEPP.ObjectType, null, properties, 0, 3760);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.CertificateMenuEntityEPP", base.GetFieldProperties(), 591248241, 515403516);
            return fieldProperties;
        }

		
    }
}