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

namespace Black.Save.Player
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class SaveBuffStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int buff;
		public int level;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveBuffStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Player.SaveBuffStruct", 0, Black.Save.Player.SaveBuffStruct.ObjectType, null, properties, 0, 8);
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

            fieldProperties = new PropertyContainer("Black.Save.Player.SaveBuffStruct", null, 432806241, -1052676411);
            
			
			
			fieldProperties.AddProperty(new Property("buff", 1244307660, "Black.Actor.BUFF", 0, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("level", 2610554845, "int", 4, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}