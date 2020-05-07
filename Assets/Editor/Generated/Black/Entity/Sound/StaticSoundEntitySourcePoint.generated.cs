using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Sound
{
    public partial class StaticSoundEntitySourcePoint : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new StaticSoundEntitySourcePoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Sound.StaticSoundEntitySourcePoint", 0, Black.Entity.Sound.StaticSoundEntitySourcePoint.ObjectType, null, properties, 0, 256);
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

            fieldProperties = new PropertyContainer("Black.Entity.Sound.StaticSoundEntitySourcePoint", base.GetFieldProperties(), -1114565364, 272869705);
            return fieldProperties;
        }

		
    }
}