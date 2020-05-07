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
            
			
			
			fieldProperties.AddProperty(new Property("rideStatus_", 951484946, "int32_t", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("pos_", 1659354338, "double", 8, 24, 3, Property.PrimitiveType.Double, 0, (char)8));
			fieldProperties.AddProperty(new Property("rotate_", 2510998735, "Luminous.Math.VectorA", 32, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("restFuel_", 3309956636, "float", 48, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("totalDistance_", 1765595455, "float", 52, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("hp_", 429453646, "int", 56, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxHp_", 3632677602, "int", 60, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("roofState_", 1595411341, "int", 64, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("visitedParkingList_", 2921630232, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleVisitedParkingStruct >", 72, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("isFreeSelectDriveMode_", 2312816435, "bool", 88, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("specLevel_", 2424419865, "SQEX.Ebony.Std.DynamicArray< Black.Save.Vehicle.SaveVehicleSpecStruct >", 96, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("looks_", 341651552, "Black.Save.Vehicle.SaveVehicleLooksStruct", 112, 840, 3, Property.PrimitiveType.ClassField, 0, (char)8));
			fieldProperties.AddProperty(new Property("isAirCraft_", 3856634868, "bool", 952, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("albumId_", 1059704378, "SQEX.Ebony.Std.Fixid", 956, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("musicId_", 1892219602, "SQEX.Ebony.Std.Fixid", 960, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}