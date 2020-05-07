using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Ambient
{
    public partial class AmbientDespawnPointEntity : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float radius_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AmbientDespawnPointEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Ambient.AmbientDespawnPointEntity", 0, Black.AI.Ambient.AmbientDespawnPointEntity.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.AI.Ambient.AmbientDespawnPointEntity", base.GetFieldProperties(), 1951790322, -2072022482);
            return fieldProperties;
        }

		
    }
}