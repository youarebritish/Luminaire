using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.TPS.FilterNodeEntities
{
    public partial class Distance2DTrapezoidFilterNodeEntity : Black.Entity.TPS.FilterDescriptorNodeEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int subject_;
		public bool useWeightFlag_;
		public float weight_;
		public bool allowAIGraphOverride_;
		public float p0_;
		public float p1_;
		public float p2_;
		public float p3_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new Distance2DTrapezoidFilterNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.TPS.FilterNodeEntities.Distance2DTrapezoidFilterNodeEntity", 0, Black.Entity.TPS.FilterNodeEntities.Distance2DTrapezoidFilterNodeEntity.ObjectType, null, properties, 0, 336);
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

            fieldProperties = new PropertyContainer("Black.Entity.TPS.FilterNodeEntities.Distance2DTrapezoidFilterNodeEntity", base.GetFieldProperties(), -880825879, 1533398134);
            
			
			
			return fieldProperties;
        }

		
    }
}