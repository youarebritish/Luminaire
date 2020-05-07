using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Vehicle
{
    public partial class SaveVehicleStickerStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint stickerId_;
		public string texturePath_;
		public float rotate_;
		public float scale_;
		public float trans_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveVehicleStickerStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Vehicle.SaveVehicleStickerStruct", 0, Black.Save.Vehicle.SaveVehicleStickerStruct.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("Black.Save.Vehicle.SaveVehicleStickerStruct", null, -915118157, -1588153568);
            
			
			
			fieldProperties.AddProperty(new Property("stickerId_", 704769322, "SQEX.Ebony.Std.Fixid", 0, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("texturePath_", 2768224660, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("rotate_", 2510998735, "float", 24, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("scale_", 3252771946, "float", 28, 8, 2, Property.PrimitiveType.Float, 0, (char)8));
			fieldProperties.AddProperty(new Property("trans_", 1780672906, "float", 36, 8, 2, Property.PrimitiveType.Float, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}