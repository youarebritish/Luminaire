using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class DisplacementAreaEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enabled_;
		public float fadeLengthX_;
		public float fadeLengthZ_;
		public float marginX_;
		public float marginZ_;
		public UnityEngine.Vector4 scaling_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new DisplacementAreaEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.DisplacementAreaEntity", 0, Black.Entity.Node.DisplacementAreaEntity.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.DisplacementAreaEntity", base.GetFieldProperties(), 1441212106, -284999849);
            
			
			
			return fieldProperties;
        }

		
    }
}