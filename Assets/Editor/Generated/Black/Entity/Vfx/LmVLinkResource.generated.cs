using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Vfx
{
    public partial class LmVLinkResource : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> VlinkPathList;
		public int priorityType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LmVLinkResource();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Vfx.LmVLinkResource", 0, Black.Entity.Vfx.LmVLinkResource.ObjectType, null, properties, 0, 112);
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

            fieldProperties = new PropertyContainer("Black.Entity.Vfx.LmVLinkResource", base.GetFieldProperties(), -908487107, 155910222);
            return fieldProperties;
        }

		
    }
}