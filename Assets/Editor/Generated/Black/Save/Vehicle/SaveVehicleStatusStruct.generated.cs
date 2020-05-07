using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Vehicle
{
    public partial class SaveVehicleStatusStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int rideStatus_;
		public double pos_;
		public UnityEngine.Vector4 rotate_;
		public float restFuel_;
		public float totalDistance_;
		public int hp_;
		public int maxHp_;
		public int roofState_;
		public IList<Black.Save.Vehicle.SaveVehicleVisitedParkingStruct> visitedParkingList_;
		public bool isFreeSelectDriveMode_;
		public IList<Black.Save.Vehicle.SaveVehicleSpecStruct> specLevel_;
		public Black.Save.Vehicle.SaveVehicleLooksStruct looks_;
		public bool isAirCraft_;
		public uint albumId_;
		public uint musicId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveVehicleStatusStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Vehicle.SaveVehicleStatusStruct", 0, Black.Save.Vehicle.SaveVehicleStatusStruct.ObjectType, null, properties, 0, 976);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Save.Vehicle.SaveVehicleStatusStruct", null, -948430382, -183003168);
            
			
			
			return fieldProperties;
        }

		
    }
}