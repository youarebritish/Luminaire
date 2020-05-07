using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Prefab
{
    public partial class PrefabTransformEntity : Black.Entity.GroupPivotTransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PrefabTransformEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Prefab.PrefabTransformEntity", 0, Black.Entity.Prefab.PrefabTransformEntity.ObjectType, null, properties, 0, 272);
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

            fieldProperties = new PropertyContainer("Black.Entity.Prefab.PrefabTransformEntity", base.GetFieldProperties(), -1551775936, -1398626961);
            
			
			
			return fieldProperties;
        }

		
    }
}