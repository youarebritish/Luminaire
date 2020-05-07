using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity
{
    public partial class TransformEntity : SQEX.Ebony.Framework.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TransformEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.TransformEntity", 0, Black.Entity.TransformEntity.ObjectType, null, properties, 0, 256);
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

            fieldProperties = new PropertyContainer("Black.Entity.TransformEntity", base.GetFieldProperties(), -643749313, -785702422);
            return fieldProperties;
        }

		
    }
}