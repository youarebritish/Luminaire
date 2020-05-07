using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Physics
{
    public partial class VehicleGearDataItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float gearRatio_;
		public float autoGearUpRotateRatio_;
		public float autoGearDownRotateRatio_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VehicleGearDataItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Physics.VehicleGearDataItem", 0, Black.Entity.Data.Physics.VehicleGearDataItem.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Physics.VehicleGearDataItem", base.GetFieldProperties(), 1369837609, -1973854972);
            return fieldProperties;
        }

		
    }
}