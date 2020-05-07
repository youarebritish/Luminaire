using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Sound
{
    public partial class StaticMenuSoundEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float soundVolume_;
		public string idxFilePath_;
		public int soundNumber_;
		public float soundFadeOutTime_;
		public uint entitySearchLabelId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new StaticMenuSoundEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Sound.StaticMenuSoundEntity", 0, Black.Entity.Sound.StaticMenuSoundEntity.ObjectType, null, properties, 0, 168);
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

            fieldProperties = new PropertyContainer("Black.Entity.Sound.StaticMenuSoundEntity", base.GetFieldProperties(), 371678761, 554121147);
            
			
			
			return fieldProperties;
        }

		
    }
}