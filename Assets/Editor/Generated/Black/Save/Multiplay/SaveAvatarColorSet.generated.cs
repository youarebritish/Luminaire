using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Multiplay
{
    public partial class SaveAvatarColorSet
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.Save.Multiplay.SaveAvatarColor Color1;
		public Black.Save.Multiplay.SaveAvatarColor Color2;
		public Black.Save.Multiplay.SaveAvatarColor Color3;
		public Black.Save.Multiplay.SaveAvatarColor Color4;
		public Black.Save.Multiplay.SaveAvatarColor Color5;
		public Black.Save.Multiplay.SaveAvatarColor Color6;
		public Black.Save.Multiplay.SaveAvatarColor Color7;
		public Black.Save.Multiplay.SaveAvatarColor Color8;
		public Black.Save.Multiplay.SaveAvatarColor Color9;
		public Black.Save.Multiplay.SaveAvatarColor Color10;
		public Black.Save.Multiplay.SaveAvatarColor Color11;
		public Black.Save.Multiplay.SaveAvatarColor Color12;
		public Black.Save.Multiplay.SaveAvatarColor Color13;
		public Black.Save.Multiplay.SaveAvatarColor Color14;
		public Black.Save.Multiplay.SaveAvatarColor Color15;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveAvatarColorSet();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Multiplay.SaveAvatarColorSet", 0, Black.Save.Multiplay.SaveAvatarColorSet.ObjectType, null, properties, 0, 240);
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

            fieldProperties = new PropertyContainer("Black.Save.Multiplay.SaveAvatarColorSet", null, 73179319, -1316285610);
            
			fieldProperties.AddProperty(new Property("Color1", 1673244779, "Black.Save.Multiplay.SaveAvatarColor", 0, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color2", 1690022398, "Black.Save.Multiplay.SaveAvatarColor", 16, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color3", 1706800017, "Black.Save.Multiplay.SaveAvatarColor", 32, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color4", 1723577636, "Black.Save.Multiplay.SaveAvatarColor", 48, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color5", 1740355255, "Black.Save.Multiplay.SaveAvatarColor", 64, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color6", 1757132874, "Black.Save.Multiplay.SaveAvatarColor", 80, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color7", 1773910493, "Black.Save.Multiplay.SaveAvatarColor", 96, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color8", 1522246208, "Black.Save.Multiplay.SaveAvatarColor", 112, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color9", 1539023827, "Black.Save.Multiplay.SaveAvatarColor", 128, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color10", 1534500673, "Black.Save.Multiplay.SaveAvatarColor", 144, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color11", 1517723054, "Black.Save.Multiplay.SaveAvatarColor", 160, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color12", 1500945435, "Black.Save.Multiplay.SaveAvatarColor", 176, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color13", 1484167816, "Black.Save.Multiplay.SaveAvatarColor", 192, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color14", 1601611149, "Black.Save.Multiplay.SaveAvatarColor", 208, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Color15", 1584833530, "Black.Save.Multiplay.SaveAvatarColor", 224, 16, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}