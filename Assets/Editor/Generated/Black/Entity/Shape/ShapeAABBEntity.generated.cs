using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Shape
{
    public partial class ShapeAABBEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 scaling_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ShapeAABBEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Shape.ShapeAABBEntity", 0, Black.Entity.Shape.ShapeAABBEntity.ObjectType, null, properties, 0, 272);
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

            fieldProperties = new PropertyContainer("Black.Entity.Shape.ShapeAABBEntity", base.GetFieldProperties(), 953238852, -1928205221);
            
			
			
			return fieldProperties;
        }

		
    }
}