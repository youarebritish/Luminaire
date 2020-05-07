using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Minigame.Fishing
{
    public partial class FishingFishSpawnEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int spawnAreaType_;
		public float boxEllipseWidth_;
		public float boxEllipseDepth_;
		public float circleRadius_;
		public int spawnLevel_;
		public int spawnMaxCount_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new FishingFishSpawnEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Minigame.Fishing.FishingFishSpawnEntity", 0, Black.Entity.Minigame.Fishing.FishingFishSpawnEntity.ObjectType, null, properties, 0, 288);
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

            fieldProperties = new PropertyContainer("Black.Entity.Minigame.Fishing.FishingFishSpawnEntity", base.GetFieldProperties(), -1492454248, 2089582880);
            
			
			
			return fieldProperties;
        }

		
    }
}