using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class VehiclePointNodeEntity : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint destId_;
		public uint destNameId_;
		public uint destTabId_;
		public uint mapIconID_;
		public bool asDestinationPoint_;
		public int destType_;
		public string destName_;
		public uint groupedDestId_;
		public float canGetOffRange_;
		public bool canEnterOnOutOfGus_;
		public bool isParkOnRoadShoulder_;
		public float nearDistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VehiclePointNodeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.VehiclePointNodeEntity", 0, Black.Entity.Node.VehiclePointNodeEntity.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.VehiclePointNodeEntity", base.GetFieldProperties(), 1104864131, -735842491);
            
			
			
			return fieldProperties;
        }

		
    }
}