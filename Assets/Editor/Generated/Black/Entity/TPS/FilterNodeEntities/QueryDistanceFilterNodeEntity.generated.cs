using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.TPS.FilterNodeEntities
{
    public partial class QueryDistanceFilterNodeEntity : Black.Entity.TPS.FilterDescriptorNodeEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int subject_;
		public bool useRadius_;
		public int allowAIGraphOverride_;
		public float maxDistance_;
		public float minDistance_;
		public float weight_;
		public int distanceType_;
		public float distance_;
		public bool invalidDistanceType_;
		public bool useMaxFlag_;
		public bool useMinFlag_;
		public bool useWeightFlag_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new QueryDistanceFilterNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.TPS.FilterNodeEntities.QueryDistanceFilterNodeEntity", 0, Black.Entity.TPS.FilterNodeEntities.QueryDistanceFilterNodeEntity.ObjectType, null, properties, 0, 344);
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

            fieldProperties = new PropertyContainer("Black.Entity.TPS.FilterNodeEntities.QueryDistanceFilterNodeEntity", base.GetFieldProperties(), 1037075594, 1325439846);
            return fieldProperties;
        }

		
    }
}