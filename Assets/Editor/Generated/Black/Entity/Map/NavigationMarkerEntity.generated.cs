using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Map
{
    public partial class NavigationMarkerEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 scaling_;
		public bool isDebugDraw_;
		public bool isDynamic_;
		public bool isCollisionType_;
		public int navMaterialType_;
		public int shapeType_;
		public bool isDisabled_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NavigationMarkerEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Map.NavigationMarkerEntity", 0, Black.Entity.Map.NavigationMarkerEntity.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.Entity.Map.NavigationMarkerEntity", base.GetFieldProperties(), -953315506, -36853962);
            
			
			
			return fieldProperties;
        }

		
    }
}