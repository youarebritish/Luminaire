using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Vfx
{
    public partial class LmVLinkEntity : Black.Entity.Vfx.LmVFXEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string vlinkPath_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LmVLinkEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Vfx.LmVLinkEntity", 0, Black.Entity.Vfx.LmVLinkEntity.ObjectType, null, properties, 0, 496);
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

            fieldProperties = new PropertyContainer("Black.Entity.Vfx.LmVLinkEntity", base.GetFieldProperties(), -903030181, -1787191690);
            
			
			
			return fieldProperties;
        }

		
    }
}