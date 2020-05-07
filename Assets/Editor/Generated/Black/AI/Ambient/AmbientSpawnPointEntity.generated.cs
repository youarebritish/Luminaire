using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Ambient
{
    public partial class AmbientSpawnPointEntity : Black.AI.Ambient.AmbientActPoint
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint archeType_;
		public IList<Black.AI.Ambient.AmbientArchetypeArrayItem> additionalArchetypes_;
		public uint initScript_;
		public bool spawnInCamera_;
		public int priority_;
		public int actorMode_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AmbientSpawnPointEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Ambient.AmbientSpawnPointEntity", 0, Black.AI.Ambient.AmbientSpawnPointEntity.ObjectType, null, properties, 0, 384);
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

            fieldProperties = new PropertyContainer("Black.AI.Ambient.AmbientSpawnPointEntity", base.GetFieldProperties(), 2066299506, -1684836506);
            
			
			
			return fieldProperties;
        }

		
    }
}