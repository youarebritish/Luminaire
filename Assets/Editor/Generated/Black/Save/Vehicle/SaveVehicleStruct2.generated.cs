//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;

namespace Black.Save.Vehicle
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class SaveVehicleStruct2
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		[UnityEngine.SerializeReference] public Black.Save.Vehicle.SaveVehicleStatusStruct2 status_;
		[UnityEngine.SerializeReference] public Black.Save.Vehicle.SaveVehicleScore scores_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveVehicleStruct2();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Vehicle.SaveVehicleStruct2", 0, Black.Save.Vehicle.SaveVehicleStruct2.ObjectType, null, properties, 0, 64);
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

            fieldProperties = new PropertyContainer("Black.Save.Vehicle.SaveVehicleStruct2", null, 2068116943, 391953859);
            
			fieldProperties.AddIndirectlyProperty(new Property("status_.regaliaType_", 2751495280, "int", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("status_.spare_pos_", 2076954725, "double", 8, 24, 3, Property.PrimitiveType.Double, 0, (char)8));
			fieldProperties.AddIndirectlyProperty(new Property("status_.spare_rotate_", 1690189802, "Luminous.Math.VectorA", 32, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scores_.jumpScore_", 2383416348, "int", 48, 12, 3, Property.PrimitiveType.Int32, 0, (char)8));
			
			
			fieldProperties.AddProperty(new Property("status_", 4107102736, "Black.Save.Vehicle.SaveVehicleStatusStruct2", 0, 48, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("scores_", 1633445687, "Black.Save.Vehicle.SaveVehicleScore", 48, 12, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}