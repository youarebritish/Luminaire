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

namespace Black.Save.Multiplay
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class SaveAvatarColor
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float R;
		public float G;
		public float B;
		public bool IsDefault;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveAvatarColor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Multiplay.SaveAvatarColor", 0, Black.Save.Multiplay.SaveAvatarColor.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("Black.Save.Multiplay.SaveAvatarColor", null, -1901913412, -169482275);
            
			
			
			fieldProperties.AddProperty(new Property("R", 3607893173, "float", 0, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("G", 3255563174, "float", 4, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("B", 3339451269, "float", 8, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("IsDefault", 101743630, "bool", 12, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}