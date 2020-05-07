using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Render
{
    public partial class AOLightEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 scaling_;
		public bool enabled_;
		public float intensity_;
		public float innerRadius_;
		public float outerRadius_;
		public bool boxShape_;
		public bool renderDebug_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AOLightEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Render.AOLightEntity", 0, Black.Entity.Render.AOLightEntity.ObjectType, null, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.Entity.Render.AOLightEntity", base.GetFieldProperties(), 1384017094, 1529272373);
            
			
			
			return fieldProperties;
        }

		
    }
}