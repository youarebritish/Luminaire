using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Sound
{
    public partial class StaticSoundEntityGroup : SQEX.Ebony.Framework.Entity.EntityGroup
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float soundVolume_;
		public float soundPitch_;
		public float soundFadeInTime_;
		public float soundFadeOutTime_;
		public bool soundVisibleFlag_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new StaticSoundEntityGroup();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Sound.StaticSoundEntityGroup", 0, Black.Entity.Sound.StaticSoundEntityGroup.ObjectType, null, properties, 0, 240);
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

            fieldProperties = new PropertyContainer("Black.Entity.Sound.StaticSoundEntityGroup", base.GetFieldProperties(), 416668671, -1289351793);
            return fieldProperties;
        }

		
    }
}