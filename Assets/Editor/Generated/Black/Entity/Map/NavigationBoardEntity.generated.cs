using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Map
{
    public partial class NavigationBoardEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float sizeX_;
		public float sizeZ_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NavigationBoardEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Map.NavigationBoardEntity", 0, Black.Entity.Map.NavigationBoardEntity.ObjectType, null, properties, 0, 272);
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

            fieldProperties = new PropertyContainer("Black.Entity.Map.NavigationBoardEntity", base.GetFieldProperties(), 1337673724, -1862829738);
            return fieldProperties;
        }

		
    }
}