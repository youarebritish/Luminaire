using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Sound
{
    public partial class SoundAroundEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float fadeTime_;
		public float fadeInTime_;
		public float fadeOutTime_;
		public string idxFilePath_;
		public float aroundRadius_;
		public int measureFrame_;
		public int peopleType_;
		public bool bDefaultPlay_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SoundAroundEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Sound.SoundAroundEntity", 0, Black.Entity.Sound.SoundAroundEntity.ObjectType, null, properties, 0, 208);
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

            fieldProperties = new PropertyContainer("Black.Entity.Sound.SoundAroundEntity", base.GetFieldProperties(), -397116247, -2134374313);
            return fieldProperties;
        }

		
    }
}