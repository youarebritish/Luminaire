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

namespace SQEX.Luminous.InputDevice
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class PadData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int PushMap;
		public float ButtonValue;
		public float Stick;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PadData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Luminous.InputDevice.PadData", 0, SQEX.Luminous.InputDevice.PadData.ObjectType, null, properties, 0, 116);
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

            fieldProperties = new PropertyContainer("SQEX.Luminous.InputDevice.PadData", null, -551833698, -692203151);
            
			
			
			fieldProperties.AddProperty(new Property("PushMap", 939908201, "uint32_t", 0, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("ButtonValue", 1864406462, "float", 4, 96, 24, Property.PrimitiveType.Float, 0, (char)8));
			fieldProperties.AddProperty(new Property("Stick", 2393108199, "float", 100, 16, 4, Property.PrimitiveType.Float, 0, (char)8));
			
			
			return fieldProperties;
        }

		
    }
}