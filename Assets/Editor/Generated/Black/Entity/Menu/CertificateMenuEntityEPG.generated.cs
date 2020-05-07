using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class CertificateMenuEntityEPG : Black.Entity.Menu.CertificateMenuEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CertificateMenuEntityEPG();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.CertificateMenuEntityEPG", 0, Black.Entity.Menu.CertificateMenuEntityEPG.ObjectType, null, properties, 0, 3504);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.CertificateMenuEntityEPG", base.GetFieldProperties(), 592231281, -2026481140);
            return fieldProperties;
        }

		
    }
}