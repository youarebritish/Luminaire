using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Vehicle
{
    public partial class VehicleNavigationDestIdItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint destId_;
		public bool isStop_;
		public float standingTime_;
		public bool isKeepDirection_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new VehicleNavigationDestIdItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Vehicle.VehicleNavigationDestIdItem", 0, Black.Sequence.Actor.AI.Vehicle.VehicleNavigationDestIdItem.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Vehicle.VehicleNavigationDestIdItem", base.GetFieldProperties(), -1984669807, -520588267);
            
			
			
			return fieldProperties;
        }

		
    }
}