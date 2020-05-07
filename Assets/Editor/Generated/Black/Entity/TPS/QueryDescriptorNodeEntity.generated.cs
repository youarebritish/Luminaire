using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.TPS
{
    public partial class QueryDescriptorNodeEntity : Black.Entity.TPS.FallbackQueryDescriptorNodeEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint fixId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new QueryDescriptorNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.TPS.QueryDescriptorNodeEntity", 0, Black.Entity.TPS.QueryDescriptorNodeEntity.ObjectType, null, properties, 0, 288);
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

            fieldProperties = new PropertyContainer("Black.Entity.TPS.QueryDescriptorNodeEntity", base.GetFieldProperties(), -1289000621, 847451784);
            
			
			
			return fieldProperties;
        }

		
    }
}