using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Physics
{
    public partial class VehicleSteeringPerSpeedCurveDataItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float speedPerHour_;
		public float steeringRatio_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VehicleSteeringPerSpeedCurveDataItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Physics.VehicleSteeringPerSpeedCurveDataItem", 0, Black.Entity.Data.Physics.VehicleSteeringPerSpeedCurveDataItem.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.Physics.VehicleSteeringPerSpeedCurveDataItem", base.GetFieldProperties(), -1270981475, -244614919);
            return fieldProperties;
        }

		
    }
}