using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node.Corps
{
    public partial class ReinforceAppearPointEntity : Black.Entity.TransformGroupEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint appearWaitMessage;
		public uint appearSortieMessage;
		public int appearSpotNo_;
		public int appearLineNo_;
		public int appearProductionType_;
		public int reinforceGroup_;
		public int generatePriority;
		public float generateSpan_;
		public Black.Entity.RoutePoint.RouteEntity appearRoutePointEntity_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ReinforceAppearPointEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.Corps.ReinforceAppearPointEntity", 0, Black.Entity.Node.Corps.ReinforceAppearPointEntity.ObjectType, null, properties, 0, 400);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.Corps.ReinforceAppearPointEntity", base.GetFieldProperties(), -325723361, 1477425493);
            
			
			
			return fieldProperties;
        }

		
    }
}