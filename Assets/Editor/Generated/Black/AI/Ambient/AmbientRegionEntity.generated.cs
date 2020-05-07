using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Ambient
{
    public partial class AmbientRegionEntity : SQEX.Ebony.Framework.Entity.EntityGroup
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float height_;
		public int capacity_;
		public uint type_;
		public uint spawnQuery_;
		public uint strollingQuery_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> excludedArchetypes_;
		public bool allowStrolling_;
		public bool debugDraw_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AmbientRegionEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Ambient.AmbientRegionEntity", 0, Black.AI.Ambient.AmbientRegionEntity.ObjectType, null, properties, 0, 336);
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

            fieldProperties = new PropertyContainer("Black.AI.Ambient.AmbientRegionEntity", base.GetFieldProperties(), -272736211, 983605238);
            
			
			
			return fieldProperties;
        }

		
    }
}