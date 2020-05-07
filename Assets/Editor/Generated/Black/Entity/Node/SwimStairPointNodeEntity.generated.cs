using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class SwimStairPointNodeEntity : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SwimStairPointNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.SwimStairPointNodeEntity", 0, Black.Entity.Node.SwimStairPointNodeEntity.ObjectType, null, properties, 0, 304);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.SwimStairPointNodeEntity", base.GetFieldProperties(), 1022488916, 245441788);
            return fieldProperties;
        }

		
    }
}