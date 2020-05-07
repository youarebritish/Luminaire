using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class FreeRunPointNodeEntity : Black.Entity.Node.PointNodeEntityValidBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool stand_;
		public int paramNo_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new FreeRunPointNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.FreeRunPointNodeEntity", 0, Black.Entity.Node.FreeRunPointNodeEntity.ObjectType, null, properties, 0, 336);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.FreeRunPointNodeEntity", base.GetFieldProperties(), -1164094976, 1215159360);
            
			
			
			return fieldProperties;
        }

		
    }
}