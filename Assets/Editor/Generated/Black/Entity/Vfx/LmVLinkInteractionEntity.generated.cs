using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Vfx
{
    public partial class LmVLinkInteractionEntity : Black.Entity.Vfx.LmVLinkEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool forceUpdateWorldPosition_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LmVLinkInteractionEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Vfx.LmVLinkInteractionEntity", 0, Black.Entity.Vfx.LmVLinkInteractionEntity.ObjectType, null, properties, 0, 544);
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

            fieldProperties = new PropertyContainer("Black.Entity.Vfx.LmVLinkInteractionEntity", base.GetFieldProperties(), -79805361, -1931993299);
            return fieldProperties;
        }

		
    }
}