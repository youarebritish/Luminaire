using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Map
{
    public partial class NavigationSeedPointEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isDebugDraw_;
		public bool isDisabled_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NavigationSeedPointEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Map.NavigationSeedPointEntity", 0, Black.Entity.Map.NavigationSeedPointEntity.ObjectType, null, properties, 0, 272);
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

            fieldProperties = new PropertyContainer("Black.Entity.Map.NavigationSeedPointEntity", base.GetFieldProperties(), 1891450319, -2086386151);
            return fieldProperties;
        }

		
    }
}