using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu.Impl.MultiPlayer
{
    public partial class MultiPlayerConvertToPowerMenuEntity : Black.Entity.Menu.SwfEntryEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MultiPlayerConvertToPowerMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.Impl.MultiPlayer.MultiPlayerConvertToPowerMenuEntity", 0, Black.Entity.Menu.Impl.MultiPlayer.MultiPlayerConvertToPowerMenuEntity.ObjectType, null, properties, 0, 496);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.Impl.MultiPlayer.MultiPlayerConvertToPowerMenuEntity", base.GetFieldProperties(), 1139856423, 1695759967);
            return fieldProperties;
        }

		
    }
}