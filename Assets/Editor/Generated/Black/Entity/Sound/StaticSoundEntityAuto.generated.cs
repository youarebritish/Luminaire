using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Sound
{
    public partial class StaticSoundEntityAuto : Black.Entity.Sound.StaticSoundEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new StaticSoundEntityAuto();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Sound.StaticSoundEntityAuto", 0, Black.Entity.Sound.StaticSoundEntityAuto.ObjectType, null, properties, 0, 608);
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

            fieldProperties = new PropertyContainer("Black.Entity.Sound.StaticSoundEntityAuto", base.GetFieldProperties(), -1614718878, -794202411);
            return fieldProperties;
        }

		
    }
}