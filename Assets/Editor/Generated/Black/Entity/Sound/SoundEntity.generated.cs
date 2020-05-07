using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Sound
{
    public partial class SoundEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int soundID_;
		public uint soundFixID_;
		public float soundVolume_;
		public float soundFadeInTime_;
		public float soundFadeOutTime_;
		public bool soundVisibleFlag_;
		public bool soundLoopFlag_;
		public bool soundVisibleDistanceFlag_;
		public float soundVisibleDistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SoundEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Sound.SoundEntity", 0, Black.Entity.Sound.SoundEntity.ObjectType, null, properties, 0, 288);
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

            fieldProperties = new PropertyContainer("Black.Entity.Sound.SoundEntity", base.GetFieldProperties(), 181377603, -1924626573);
            return fieldProperties;
        }

		
    }
}