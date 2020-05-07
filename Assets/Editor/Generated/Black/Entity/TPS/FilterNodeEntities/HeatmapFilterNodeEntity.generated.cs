using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.TPS.FilterNodeEntities
{
    public partial class HeatmapFilterNodeEntity : Black.Entity.TPS.FilterDescriptorNodeEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint influenceMapFixId_;
		public float maxHeat_;
		public float minHeat_;
		public float filterWeight_;
		public bool useMaxFlag_;
		public bool useMinFlag_;
		public bool useWeightFlag_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new HeatmapFilterNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.TPS.FilterNodeEntities.HeatmapFilterNodeEntity", 0, Black.Entity.TPS.FilterNodeEntities.HeatmapFilterNodeEntity.ObjectType, null, properties, 0, 328);
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

            fieldProperties = new PropertyContainer("Black.Entity.TPS.FilterNodeEntities.HeatmapFilterNodeEntity", base.GetFieldProperties(), 1210240270, 1579852038);
            return fieldProperties;
        }

		
    }
}