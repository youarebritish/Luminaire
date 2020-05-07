using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Map
{
    public partial class NavigationPylonEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float height_;
		public float depth_;
		public float width_;
		public int pylonID_;
		public bool isDebugDraw_;
		public string packageName_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NavigationPylonEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Map.NavigationPylonEntity", 0, Black.Entity.Map.NavigationPylonEntity.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.Entity.Map.NavigationPylonEntity", base.GetFieldProperties(), 1872146967, -828872621);
            return fieldProperties;
        }

		
    }
}